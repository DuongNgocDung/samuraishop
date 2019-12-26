using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IProductService
    {
        Product Add(Product dto);

        void Update(Product dto);

        Product Delete(Product dto);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Product> GetAllPagingByTag(string tag, int page, int pageSize, out int totalRow);

        IEnumerable<Product> GetPagingByCategoryID(int categoryID, int page, int pageSize, out int totalRow);

        Product GetByKey(int id);

        void SaveChanges();
    }
}