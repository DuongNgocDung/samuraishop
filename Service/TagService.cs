using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class TagService : ITagService
    {
        private ITagRepository _tagRepository;
        private IUnitOfWork _unitOfWork;

        public TagService(ITagRepository tagRepository, IUnitOfWork unitOfWork)
        {
            _tagRepository = tagRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public Tag Add(Tag dto)
        {
            return _tagRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(Tag dto)
        {
            _tagRepository.Update(dto);
        }

        /// <summary>
        /// delete data
        /// </summary>
        /// <param name="dto"></param>
        public Tag Delete(Tag dto)
        {
            return _tagRepository.Delete(dto);
        }

        /// <summary>
        /// get paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<Tag> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _tagRepository.GetMultiPaging(x => x == x, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Tag GetByKey(string id)
        {
            return _tagRepository.GetSingleById(new object[] { id });
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