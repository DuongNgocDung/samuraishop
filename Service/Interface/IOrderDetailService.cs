using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IOrderDetailService
    {
        OrderDetail Add(OrderDetail dto);

        void Update(OrderDetail dto);

        OrderDetail Delete(OrderDetail dto);

        IEnumerable<OrderDetail> GetAllPaging(int page, int pageSize, out int totalRow);

        OrderDetail GetByKey(int productID, int orderID);

        void SaveChanges();
    }
}