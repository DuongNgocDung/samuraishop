using Data.Infrastructure;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class SystemConfigRepository : RepositoryBase<SystemConfig>
    {
        public SystemConfigRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
