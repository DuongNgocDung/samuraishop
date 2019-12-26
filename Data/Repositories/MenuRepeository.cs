using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class MenuRepeository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepeository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
