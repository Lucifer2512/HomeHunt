using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IPostServices
    {
        Task<IEnumerable<Post>> GetPosts(bool? Status);
        Task<Post> GetPostByIdAsyncAndStatus(Guid id, bool? Status);
        Task<Post> GetPostByIdAsync(Guid id);
        Task CreatePostAsync(Post post);
        Task UpdatePostAsync(Post post);
        Task DeletePostAsync(Guid id);
    }
}
