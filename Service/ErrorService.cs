using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System;

namespace Service
{
    public class ErrorService : IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitOfWork)
        {
            _errorRepository = errorRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new error
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public Error Add(Error dto)
        {
            return _errorRepository.Add(dto);
        }

        /// <summary>
        /// save changes
        /// </summary>
        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}