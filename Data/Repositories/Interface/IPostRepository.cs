using Data.Infrastructure;
using Model.Models;
using System.Collections.Generic;

namespace Data.Repositories.Interface
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetMultiPagingByTag(string tag, int page, int pageSize, out int totalRow);
    }
}