using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IFooterService
    {
        Footer Add(Footer dto);

        void Update(Footer dto);

        Footer Delete(Footer dto);

        IEnumerable<Footer> GetAll();

        IEnumerable<Footer> GetAllPaging(int page, int pageSize, out int totalRow);

        Footer GetByKey(string id);

        void SaveChanges();
    }
}