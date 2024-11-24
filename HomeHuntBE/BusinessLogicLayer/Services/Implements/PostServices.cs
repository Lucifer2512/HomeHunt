using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Implements
{
    public class PostServices : IPostServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Post>> GetPosts(bool? Status)
        {
            IEnumerable<Post> posts = null;
            if (Status.HasValue)
            {
                posts = await _unitOfWork.Repository<Post>()
                    .AsQueryable(p => p.Status == Status.Value)
                    .Include(u => u.User)
                    .Include(u => u.Transaction)
                    .ToListAsync();
            }
            else
            {
                posts = await _unitOfWork.Repository<Post>()
                    .AsQueryable(p => p.Status == Status)
                    .Include(u => u.User)
                    .Include(u => u.Transaction)
                    .ToListAsync();
            }

            return posts;
        }

        public async Task<Post> GetPostByIdAndStatus(Guid id, bool? Status)
        {
            Post post = null;
            if (Status.HasValue)
            {
                post = await _unitOfWork.Repository<Post>()
                    .AsQueryable(p => p.Status == Status.Value)
                    .Include(u => u.User)
                    .Include(u => u.Transaction)
                    .FirstOrDefaultAsync();
            }
            else
            {
                post = await _unitOfWork.Repository<Post>()
                    .AsQueryable(p => p.Status == Status)
                    .Include(u => u.User)
                    .Include(u => u.Transaction)
                    .FirstOrDefaultAsync();
            }
            return post;
        }

        public async Task<Post> GetPostByIdAsync(Guid id)
        {
            return (await _unitOfWork.Repository<Post>().GetWhere(post => post.Id == id))
                   .SingleOrDefault();
        }

        public async Task CreatePostAsync(Post post)
        {
            await _unitOfWork.Repository<Post>().InsertAsync(post);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdatePostAsync(Post post)
        {
            await _unitOfWork.Repository<Post>().UpdateGuid(post, post.Id);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeletePostAsync(Guid id)
        {
            var post = await _unitOfWork.Repository<Post>().GetByIdGuid(id);
            if (post != null)
            {
                _unitOfWork.Repository<Post>().Delete(post);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
