using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory dto);

        void Update(ProductCategory dto);

        void Delete(ProductCategory dto);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<ProductCategory> GetPagingByParentID(int parentID, int page, int pageSize, out int totalRow);

        ProductCategory GetByKey(int id);

        void SaveChanges();
    }
}