﻿using BusinessLogicLayer.ResponseModels;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
	public interface IUsersService
	{
		Task<IEnumerable<User>> GetUsersAsync();
		Task<Role> getRole(string roleName);
        Task<User> GetUserByIdAsync(Guid id);
		Task CreateUserAsync(User user);
		Task UpdateUserAsync(User user);
		Task DeleteUserAsync(Guid id);
        Task<bool> UserExistsAsync(Guid id);
		Task<User> GetUserByFullNameAsync(string username);
		Task<User> GetUserByEmailAsync(string email);
		Task<UserDetailResponse> GetUserProfile(Guid id);
		Task<User> GetUserByUsernameAsync(string username);
    }

}
