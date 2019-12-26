using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class VisistorStatisticService : IVisistorStatisticService
    {
        private IVisistorStatisticRepository _visistorStatisticRepository;
        private IUnitOfWork _unitOfWork;

        public VisistorStatisticService(IVisistorStatisticRepository visistorStatisticRepository, IUnitOfWork unitOfWork)
        {
            _visistorStatisticRepository = visistorStatisticRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public void Add(VisistorStatistic dto)
        {
            _visistorStatisticRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(VisistorStatistic dto)
        {
            _visistorStatisticRepository.Update(dto);
        }

        /// <summary>
        /// delete data
        /// </summary>
        /// <param name="dto"></param>
        public void Delete(VisistorStatistic dto)
        {
            _visistorStatisticRepository.Delete(dto);
        }

        /// <summary>
        /// get paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<VisistorStatistic> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _visistorStatisticRepository.GetMultiPaging(x => x == x, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public VisistorStatistic GetByKey(int id)
        {
            return _visistorStatisticRepository.GetSingleById(id);
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