using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface ISystemConfigService
    {
        SystemConfig Add(SystemConfig dto);

        void Update(SystemConfig dto);

        SystemConfig Delete(SystemConfig dto);

        IEnumerable<SystemConfig> GetAllPaging(int page, int pageSize, out int totalRow);

        SystemConfig GetByKey(int id);

        void SaveChanges();
    }
}