using DataAccess.Entities;
using DataAccess.Implementations;
using DataAccess.Repositories.Abstractions;

namespace DataAccess.Repositories.Implementations
{
     public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(AppDbContext context) : base(context)
        {
        }
    }
}
