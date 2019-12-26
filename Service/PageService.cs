using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;

namespace Service
{
    public class PageService : IPageService
    {
        private IPageRepository _pageRepository;
        private IUnitOfWork _unitOfWork;

        public PageService(IPageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            _pageRepository = pageRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public void Add(Page dto)
        {
            _pageRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(Page dto)
        {
            _pageRepository.Update(dto);
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="dto"></param>
        public void Delete(Page dto)
        {
            _pageRepository.Delete(dto);
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