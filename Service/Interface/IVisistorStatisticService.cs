using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IVisistorStatisticService
    {
        void Add(VisistorStatistic dto);

        void Update(VisistorStatistic dto);

        void Delete(VisistorStatistic dto);

        IEnumerable<VisistorStatistic> GetAllPaging(int page, int pageSize, out int totalRow);

        VisistorStatistic GetByKey(int id);

        void SaveChanges();
    }
}