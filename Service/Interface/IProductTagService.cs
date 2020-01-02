using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IProductTagService
    {
        ProductTag Add(ProductTag dto);

        void Update(ProductTag dto);

        ProductTag Delete(ProductTag dto);

        IEnumerable<ProductTag> GetAllPaging(int page, int pageSize, out int totalRow);

        ProductTag GetByKey(int productID, string tagID);

        void SaveChanges();
    }
}