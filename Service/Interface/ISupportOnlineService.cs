using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface ISupportOnlineService
    {
        SupportOnline Add(SupportOnline dto);

        void Update(SupportOnline dto);

        SupportOnline Delete(SupportOnline dto);

        IEnumerable<SupportOnline> GetAllPaging(int page, int pageSize, out int totalRow);

        SupportOnline GetByKey(int id);

        void SaveChanges();
    }
}