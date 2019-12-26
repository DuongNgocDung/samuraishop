using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class FooterService : IFooterService
    {
        private IFooterRepository _footerRepository;
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// cái này nó sẽ tự tiêm vô (service) (injection)
        /// </summary>
        /// <param name="footerRepository"></param>
        /// <param name="unitOfWork"></param>
        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public Footer Add(Footer dto)
        {
            return _footerRepository.Add(dto);
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="dto"></param>
        public Footer Delete(Footer dto)
        {
            return _footerRepository.Delete(dto);
        }

        /// <summary>
        /// update data
        /// </summary>
        /// <param name="dto"></param>
        public void Update(Footer dto)
        {
            _footerRepository.Update(dto);
        }

        /// <summary>
        /// get all records
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Footer> GetAll()
        {
            //cái hàm GetAll của repository này còn có thể trả ra những cái thuộc tính của cái bảng mà nó map tới (khóa ngoại á)
            return _footerRepository.GetAll();
        }

        /// <summary>
        /// get all and paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<Footer> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _footerRepository.GetMultiPaging(x => x == x, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Footer GetByKey(int id)
        {
            return _footerRepository.GetSingleById(id);
        }

        /// <summary>
        /// commit 1 cái mới đi vào db
        /// </summary>
        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}