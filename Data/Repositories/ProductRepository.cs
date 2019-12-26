using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Get paing by tag, from "page" page, get "pageSize" item
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow">This return all rows</param>
        /// <returns></returns>
        public IEnumerable<Product> GetMultiPagingByTag(string tag, int page, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Products
                        join pt in DbContext.ProductTags
                        on p.ID equals pt.ProductID
                        where pt.Tag.Name == tag && p.Status
                        orderby p.CategoryID, p.ID
                        select p;

            totalRow = query.Count();
            var skip = (page - 1) * pageSize;
            var display = Math.Min(totalRow - skip, pageSize);
            var finalRecords = query.Skip(skip).Take(display);
            return finalRecords;
        }
    }
}