using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;

namespace Data.Repositories
{
    public class VisistorStatisticRepository : RepositoryBase<VisistorStatistic>, IVisistorStatisticRepository
    {
        public VisistorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}