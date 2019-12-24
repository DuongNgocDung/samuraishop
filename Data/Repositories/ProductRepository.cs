using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;

namespace Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        /// <summary>
        /// cái truyền này có nghĩa là khi mà khởi tạo ProductRepository nó sẽ truyền vô 1 dbFactory
        /// và đồng thời lấy cái dbFactory đó truyền vô cái constructure của thằng base trên kia
        /// </summary>
        /// <param name="dbFactory"></param>
        public ProductRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
}