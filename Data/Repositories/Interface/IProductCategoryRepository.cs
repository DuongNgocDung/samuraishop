using Model.Models;
using System.Collections.Generic;
using Data.Infrastructure;

namespace Data.Repositories.Interface
{
    /// <summary>
    /// ở cái interface này mình sẽ định nghĩa những phương thức
    /// mà ko có sẵn trongn cái RepositoryBase kia
    /// </summary>
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetAllByAlias(string alias);
    }
}