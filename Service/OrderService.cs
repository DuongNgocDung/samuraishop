using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public Order Add(Order dto)
        {
            return _orderRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(Order dto)
        {
            _orderRepository.Update(dto);
        }

        /// <summary>
        /// delete data
        /// </summary>
        /// <param name="dto"></param>
        public Order Delete(Order dto)
        {
            return _orderRepository.Delete(dto);
        }

        /// <summary>
        /// get paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<Order> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _orderRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Order GetByKey(int id)
        {
            return _orderRepository.GetSingleById(new object[] { id });
        }

        /// <summary>
        /// commit changes
        /// </summary>
        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}