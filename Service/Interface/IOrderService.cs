using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IOrderService
    {
        void Add(Order dto);

        void Update(Order dto);

        void Delete(Order dto);

        IEnumerable<Order> GetAllPaging(int page, int pageSize, out int totalRow);

        Order GetByKey(int id);

        void SaveChanges();
    }
}