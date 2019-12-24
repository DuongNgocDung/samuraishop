using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;

namespace Data.Repositories
{
    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}