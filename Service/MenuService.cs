using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class MenuService : IMenuService
    {
        private IMenuRepository _menuRepository;
        private IUnitOfWork _unitOfWork;

        public MenuService(IMenuRepository menuRepository, IUnitOfWork unitOfWork)
        {
            _menuRepository = menuRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public Menu Add(Menu dto)
        {
            return _menuRepository.Add(dto);
        }

        /// <summary>
        /// update data
        /// </summary>
        /// <param name="dto"></param>
        public void Update(Menu dto)
        {
            _menuRepository.Update(dto);
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="dto"></param>
        public Menu Delete(Menu dto)
        {
            return _menuRepository.Delete(dto);
        }

        /// <summary>
        /// get paging all
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<Menu> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _menuRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Menu GetByKey(int id)
        {
            return _menuRepository.GetSingleById(id);
        }

        /// <summary>
        /// commnit changes
        /// </summary>
        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}