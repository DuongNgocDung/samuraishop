using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class SystemConfigService : ISystemConfigService
    {
        private ISystemConfigRepository _systemConfigRepository;
        private IUnitOfWork _unitOfWork;

        public SystemConfigService(ISystemConfigRepository systemConfigRepository, IUnitOfWork unitOfWork)
        {
            _systemConfigRepository = systemConfigRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public void Add(SystemConfig dto)
        {
            _systemConfigRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(SystemConfig dto)
        {
            _systemConfigRepository.Update(dto);
        }

        /// <summary>
        /// delete data
        /// </summary>
        /// <param name="dto"></param>
        public void Delete(SystemConfig dto)
        {
            _systemConfigRepository.Delete(dto);
        }

        /// <summary>
        /// get paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<SystemConfig> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _systemConfigRepository.GetMultiPaging(x => x == x, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SystemConfig GetByKey(int id)
        {
            return _systemConfigRepository.GetSingleById(id);
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