using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Models;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.RequestModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Drawing;
using BusinessLogicLayer.ResponseModels;
using DataAccessLayer.Tools;

namespace HomeHuntAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IUsersService _userService;

		public UsersController(IUsersService userService)
		{
			_userService = userService;

        }

		// GET: api/Users
		[HttpGet]
		[Authorize]
		public async Task<ActionResult<IEnumerable<UserDetailResponse>>> GetUsers()
		{
			var users = await _userService.GetUsersAsync();

            var userViewModels = new List<UserDetailResponse>();

            foreach (var user in users)
            {
                var userViewModel = new UserDetailResponse
                {
                    Id = user.Id,
                    Username = user.Username,
					FullName = user.FullName,
                    //Email = user.Email,
                    Phone = user.PhoneNumber,
					//Gender = user.Gender,
					//Dob = user.Dob,
					//Address = user.Address,
                    RoleName = user.Role.Name,
                };

                userViewModels.Add(userViewModel);
            }


            return Ok(userViewModels);
		}

		// GET: api/Users/5
		[HttpGet("{id}")]
		[Authorize]
		public async Task<ActionResult<User>> GetUser(Guid id)
		{
			var user = await _userService.GetUserByIdAsync(id);
			if (user == null)
			{
				return NotFound();
			}

			return Ok(user);
		}

        [HttpGet("GetUserProfile/{id}")]
		[Authorize]
		public async Task<ActionResult<User>> GetUserProfile(Guid id)
        {
            try
            {
                var user = await _userService.GetUserProfile(id);
				return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

			// PUT: api/Users/5
		[HttpPut("{id}")]
		[Authorize]
		public async Task<IActionResult> PutUser(Guid id, UserUpdateRequestModel userModel)
		{
            try
            {
                var user = await _userService.GetUserByIdAsync(id);

				if (user == null)
				{
					return NotFound(new { message = "User ID not found." });
				}

                if (userModel.Dob.HasValue)
                {
                    user.Dob = userModel.Dob;
                }

                if (!string.IsNullOrEmpty(userModel.Email))
                {
                    user.Email = userModel.Email;
                }

                if (!string.IsNullOrEmpty(userModel.Address))
                {
                    user.Address = userModel.Address;
                }

                if (!string.IsNullOrEmpty(userModel.PhoneNumber))
                {
                    user.PhoneNumber = userModel.PhoneNumber;
                }

                if (!string.IsNullOrEmpty(userModel.Gender))
                {
                    user.Gender = userModel.Gender;
                }

                if (!string.IsNullOrEmpty(userModel.FullName))
                {
                    user.FullName = userModel.FullName;
                }
                if(!string.IsNullOrEmpty(userModel.RoleName))
                {
                    var role = await _userService.getRole(userModel.RoleName);
                    if (role != null)
                    {
                        user.RoleId = role.Id;
                    }
                }

                user.Status = userModel.Status;

                user.UpdatedDate = DateTime.UtcNow.AddHours(7);

                await _userService.UpdateUserAsync(user);

                return Ok(new { message = "User updated successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdatePassword")]
		[Authorize]
		public async Task<IActionResult> UpdatePassword(UpdatePasswordRequestModel request)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(request.UserId);
                if (user == null)
                {
                    return NotFound(new { message = "User ID not found." });
                }
				if(PasswordTools.VerifyPassword(request.OldPassword, user.Password) == false)
				{
                    return BadRequest(new { message = "Password is uncorrect." });
                }

				string hashedPass = PasswordTools.HashPassword(request.NewPassword);

                user.Password = hashedPass;

                await _userService.UpdateUserAsync(user);

                return Ok(new { message = "User Password updated successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Users
        [HttpPost]
		[Authorize]
		public async Task<ActionResult<User>> PostUser(UserCreateRequestModel userModel)
		{

            var existingUser = await _userService.GetUserByUsernameAsync(userModel.Username);
            if (existingUser != null)
            {
                return BadRequest(new { message = "UserName Existed." });
            }

            var role = await _userService.getRole(userModel.RoleName);

            // Map properties from userModel to create a new user entity
            var user = new User
			{
                Username = userModel.Username,
				FullName = userModel.FullName,
				Password = userModel.Password,
				Email = userModel.Email,
				Dob = userModel.Dob,
				Address = userModel.Address,
				PhoneNumber = userModel.PhoneNumber,
				RoleId = role.Id,
				Status = userModel.Status,
				Gender = userModel.Gender
			};

			await _userService.CreateUserAsync(user);
			return CreatedAtAction("GetUser", new { id = user.Id }, user);
		}

		// DELETE: api/Users/5
		[HttpDelete("{id}")]
		[Authorize]
		public async Task<IActionResult> DeleteUser(Guid id)
		{
			var user = await _userService.GetUserByIdAsync(id);
			if (user == null)
			{
				return NotFound();
			}

			await _userService.DeleteUserAsync(id);
			return NoContent();
		}

		private async Task<bool> UserExists(Guid id)
		{
			return await _userService.UserExistsAsync(id);
		}
	}

}
