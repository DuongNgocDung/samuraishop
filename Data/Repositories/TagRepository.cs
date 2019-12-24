using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;

namespace Data.Repositories
{
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}