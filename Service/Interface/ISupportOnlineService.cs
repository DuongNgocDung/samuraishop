using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface ISupportOnlineService
    {
        void Add(SupportOnline dto);

        void Update(SupportOnline dto);

        void Delete(SupportOnline dto);

        IEnumerable<SupportOnline> GetAllPaging(int page, int pageSize, out int totalRow);

        SupportOnline GetByKey(int id);

        void SaveChanges();
    }
}