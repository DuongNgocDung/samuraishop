using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IOrderDetailService
    {
        void Add(OrderDetail dto);

        void Update(OrderDetail dto);

        void Delete(OrderDetail dto);

        IEnumerable<OrderDetail> GetAllPaging(int page, int pageSize, out int totalRow);

        OrderDetail GetByKey(int id);

        void SaveChanges();
    }
}