using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        //nếu như kế thừa hẳn cái IRepository thì ta sẽ phải triển khai rất nhìu các phương thức
        //nhưng ở đây ta đã tạo sẵn cái RepositoryBase rồi, nó sẽ triển khai cho mình rồi
        //mình hong cần triển khai lại các phương thức đó nữa, mà chúng ta chỉ cần
        //1 cái constructure
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        #region more function
        public IEnumerable<ProductCategory> GetAllByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
        #endregion
    }
}