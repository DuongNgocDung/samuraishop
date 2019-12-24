using Model.Models;
using System.Collections.Generic;

namespace Data.Repositories.Interface
{
    /// <summary>
    /// ở cái interface này mình sẽ định nghĩa những phương thức
    /// mà ko có sẵn trongn cái RepositoryBase kia
    /// </summary>
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetAllByAlias(string alias);
    }
}