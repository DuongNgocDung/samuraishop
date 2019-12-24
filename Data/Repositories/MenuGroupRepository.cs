using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;

namespace Data.Repositories
{
    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}