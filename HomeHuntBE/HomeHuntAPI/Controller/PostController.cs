using BusinessLogicLayer.RequestModels;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Net;
using System.Numerics;
using BusinessLogicLayer.ResponseModels;

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
        public async Task<ActionResult<IEnumerable<PostResponseModel>>> GetPosts(bool? status)
        {
            try
            {
                var posts = await _postServices.GetPosts(status);

                var postList = new List<PostResponseModel>();
                foreach (var post in posts)
                {
                    var postView = new PostResponseModel
                    {
                        Id = post.Id,
                        Phoneseller = post.User?.PhoneNumber, // Safe navigation for nullable User
                        PostTitle = post.Title,
                        Description = post.Description,
                        BuildingName = post.BuildingName,
                        Images = post.ImageUrl,
                        RentPrice = post.Price,
                        Address = post.Address,
                        PropertyType = post.PropertyType,
                        ApartmentNumber = post.ApartmentNumber,
                        Block = post.Block,
                        Floor = post.Floor,
                        ApartmentType = post.ApartmentType,
                        Bedrooms = post.Bedrooms,
                        Bathrooms = post.Bathrooms,
                        LegalDocument = post.LegalDocument,
                        FurnitureCondition = post.FurnitureCondition,
                        Area = post.Area,
                        Deposit = post.Deposit,
                        UserId = post.UserId,
                        TransactionId = post.TransactionId,
                        Status = post.Status,
                        TransactionStatus = post.Transaction?.Status // Check for null Transaction
                    };
                    postList.Add(postView);
                }
                return Ok(postList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "An error occurred while processing your request.");
            }
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
        public async Task<ActionResult<Post>> AddPost([FromForm] PostCreateRequestModel postModel)
        {
            var post = new Post
            {
                Title = postModel.Title,
                Description = postModel.Description,
                ImageUrl = postModel.ImageUrl,
                BuildingName = postModel.BuildingName,
                Price = postModel.Price,
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
                TransactionId = Guid.NewGuid(),
                Status = null
            };


            await _postServices.CreatePostAsync(post);
            return CreatedAtAction("GetPost", new { id = post.Id }, post);
        }

        // PUT: api/Posts/{id}
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdatePost(Guid id, [FromForm] PostUpdateRequestModel postModel)
        {
            var post = await _postServices.GetPostByIdAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            // Skip updating if the value is null
            if (!string.IsNullOrEmpty(postModel.Title))
            { post.Title = postModel.Title; }

            if (!string.IsNullOrEmpty(postModel.Description))
            { post.Description = postModel.Description; }

            if (postModel.ImageUrl != null)
            { post.ImageUrl = postModel.ImageUrl; }

            if (!string.IsNullOrEmpty(postModel.BuildingName))
            { post.BuildingName = postModel.BuildingName; }

            if (postModel.Price.HasValue)
            { post.Price = postModel.Price.Value; }

            if (!string.IsNullOrEmpty(postModel.Address))
            { post.Address = postModel.Address; }

            if (!string.IsNullOrEmpty(postModel.PropertyType))
            { post.PropertyType = postModel.PropertyType; }

            if (!string.IsNullOrEmpty(postModel.ApartmentNumber))
            { post.ApartmentNumber = postModel.ApartmentNumber; }

            if (!string.IsNullOrEmpty(postModel.Block))
            { post.Block = postModel.Block; }

            if (!string.IsNullOrEmpty(postModel.Floor))
            { post.Floor = postModel.Floor; }

            if (!string.IsNullOrEmpty(postModel.ApartmentType))
            { post.ApartmentType = postModel.ApartmentType; }

            if (!string.IsNullOrEmpty(postModel.Bedrooms))
            { post.Bedrooms = postModel.Bedrooms; }

            if (!string.IsNullOrEmpty(postModel.Bathrooms))
            { post.Bathrooms = postModel.Bathrooms; }

            if (!string.IsNullOrEmpty(postModel.LegalDocument))
            { post.LegalDocument = postModel.LegalDocument; }

            if (!string.IsNullOrEmpty(postModel.FurnitureCondition))
            { post.FurnitureCondition = postModel.FurnitureCondition; }

            if (!string.IsNullOrEmpty(postModel.Area))
            { post.Area = postModel.Area; }

            if (postModel.Deposit.HasValue)
            { post.Deposit = postModel.Deposit.Value; }

            post.Status = postModel.Status;

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
