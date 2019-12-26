using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class SupportOnlineService : ISupportOnlineService
    {
        private ISupportOnlineRepository _supportOnlineRepository;
        private IUnitOfWork _unitOfWork;

        public SupportOnlineService(ISupportOnlineRepository supportOnlineRepository, IUnitOfWork unitOfWork)
        {
            _supportOnlineRepository = supportOnlineRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public SupportOnline Add(SupportOnline dto)
        {
            return _supportOnlineRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(SupportOnline dto)
        {
            _supportOnlineRepository.Update(dto);
        }

        /// <summary>
        /// delete data
        /// </summary>
        /// <param name="dto"></param>
        public SupportOnline Delete(SupportOnline dto)
        {
            return _supportOnlineRepository.Delete(dto);
        }

        /// <summary>
        /// get paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<SupportOnline> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _supportOnlineRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SupportOnline GetByKey(int id)
        {
            return _supportOnlineRepository.GetSingleById(id);
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