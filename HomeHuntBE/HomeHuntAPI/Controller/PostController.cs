using BusinessLogicLayer.RequestModels;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Net;
using System.Numerics;

namespace HomeHuntAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostServices _postServices;

        public PostController(IPostServices postServices)
        {
            _postServices = postServices;
        }

        // GET: api/Post
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<Post>> GetPosts()
        {
            var posts = _postServices.GetPosts();
            return Ok(posts);
        }

        // GET: api/Post/1
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Post>> GetPost(Guid id)
        {
            var post = await _postServices.GetPostByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        // POST: api/Posts
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<User>> AddPost(PostCreateRequestModel postModel)
        {
            // Map properties from userModel to create a new user entity
            var post = new Post
            {
                //Field = userModel.Field,
                Title = postModel.Title,
                Description = postModel.Description,
                Image = postModel.Image,
                BuildingName = postModel.BuildingName,
                Price = postModel.Price,
                Phone = postModel.Phone,
                Address = postModel.Address,
                PropertyType = postModel.PropertyType,
                ApartmentNumber = postModel.ApartmentNumber,
                Block = postModel.Block,
                Floor = postModel.Floor,
                ApartmentType = postModel.ApartmentType,
                Bedrooms = postModel.Bedrooms,
                Bathrooms = postModel.Bathrooms,
                LegalDocument = postModel.LegalDocument,
                FurnitureCondition = postModel.FurnitureCondition,
                Area = postModel.Area,
                Deposit = postModel.Deposit,
                UserId = postModel.UserId,
            };


            await _postServices.CreatePostAsync(post);
            return CreatedAtAction("GetPost", new { id = post.Id }, post);
        }

        // PUT: api/Posts/{id}
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdatePost(Guid id, PostUpdateRequestModel postModel)
        {
            var post = await _postServices.GetPostByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            post.Title = postModel.Title;
            post.Description = postModel.Description;
            post.Description = postModel.Description;
                post.Image = postModel.Image;
                post.BuildingName = postModel.BuildingName;
                post.Price = postModel.Price;
                post.Phone = postModel.Phone;
                post.Address = postModel.Address;
                post.PropertyType = postModel.PropertyType;
                post.ApartmentNumber = postModel.ApartmentNumber;
                post.Block = postModel.Block;
                post.Floor = postModel.Floor;
                post.ApartmentType = postModel.ApartmentType;
                post.Bedrooms = postModel.Bedrooms;
                post.Bathrooms = postModel.Bathrooms;
                post.LegalDocument = postModel.LegalDocument;
                post.FurnitureCondition = postModel.FurnitureCondition;
                post.Area = postModel.Area;
                post.Deposit = postModel.Deposit;
                post.UserId = postModel.UserId;

            await _postServices.UpdatePostAsync(post);
            return NoContent();
        }



        // DELETE: api/Posts/1
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            var post = await _postServices.GetPostByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            await _postServices.DeletePostAsync(id);
            return NoContent();
        }
    }
}
