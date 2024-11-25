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
                    .AsQueryable(p => p.Status == Status.Value && p.Transaction.Status==true)
                    .Include(u => u.User)
                    .Include(u => u.Transaction)
                    .ToListAsync();
            }
            else
            {
                posts = await _unitOfWork.Repository<Post>()
                    .AsQueryable(p => p.Status == Status && p.Transaction.Status == true)
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
            return await _unitOfWork.Repository<Post>().AsQueryable(p => p.Id == id)
                    .Include(u => u.User)
                    .Include(u => u.Transaction)
                    .FirstOrDefaultAsync();
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
            var transaction = (await _unitOfWork.Repository<Transaction>().GetWhere(t => t.PostId == id)).SingleOrDefault(); ;

            var post = await _unitOfWork.Repository<Post>().GetByIdGuid(id);
            if (post != null && transaction != null)
            {
                _unitOfWork.Repository<Transaction>().Delete(transaction);
                _unitOfWork.Repository<Post>().Delete(post);
                await _unitOfWork.CommitAsync();
            }
        }
    }
}
