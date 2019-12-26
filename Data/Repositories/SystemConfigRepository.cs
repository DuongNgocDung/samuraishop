using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;

namespace Data.Repositories
{
    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}