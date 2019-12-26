using Data.Infrastructure;
using Model.Models;
using System.Collections.Generic;

namespace Data.Repositories.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetMultiPagingByTag(string tag, int page, int pageSize, out int totalRow);
    }
}