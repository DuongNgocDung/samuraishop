using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;

namespace Data.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}