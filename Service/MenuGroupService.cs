using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class MenuGroupService : IMenuGroupService
    {
        private IMenuGroupRepository _menuGroupRepository;
        private IUnitOfWork _unitOfWork;

        public MenuGroupService(IMenuGroupRepository menuGroupRepository, IUnitOfWork unitOfWork)
        {
            _menuGroupRepository = menuGroupRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public void Add(MenuGroup dto)
        {
            _menuGroupRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(MenuGroup dto)
        {
            _menuGroupRepository.Update(dto);
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="dto"></param>
        public void Delete(MenuGroup dto)
        {
            _menuGroupRepository.Delete(dto);
        }

        /// <summary>
        /// get paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<MenuGroup> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _menuGroupRepository.GetMultiPaging(x => x == x, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MenuGroup GetByKey(int id)
        {
            return _menuGroupRepository.GetSingleById(id);
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