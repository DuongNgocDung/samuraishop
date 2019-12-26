using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IFooterService
    {
        void Add(Footer dto);

        void Update(Footer dto);

        void Delete(Footer dto);

        IEnumerable<Footer> GetAll();

        IEnumerable<Footer> GetAllPaging(int page, int pageSize, out int totalRow);

        Footer GetByKey(int id);

        void SaveChanges();
    }
}