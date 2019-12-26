using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IProductTagService
    {
        void Add(ProductTag dto);

        void Update(ProductTag dto);

        void Delete(ProductTag dto);

        IEnumerable<ProductTag> GetAllPaging(int page, int pageSize, out int totalRow);

        void SaveChanges();
    }
}