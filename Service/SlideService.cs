using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class SlideService : ISlideService
    {
        private ISlideRepository _slideRepository;
        private IUnitOfWork _unitOfWork;

        public SlideService(ISlideRepository slideRepository, IUnitOfWork unitOfWork)
        {
            _slideRepository = slideRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public Slide Add(Slide dto)
        {
            return _slideRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(Slide dto)
        {
            _slideRepository.Update(dto);
        }

        /// <summary>
        /// delete data
        /// </summary>
        /// <param name="dto"></param>
        public Slide Delete(Slide dto)
        {
            return _slideRepository.Delete(dto);
        }

        /// <summary>
        /// get by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Slide GetByKey(int id)
        {
            return _slideRepository.GetSingleById(new object[] { id });
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