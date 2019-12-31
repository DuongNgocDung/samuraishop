using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            _postCategoryRepository = postCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public PostCategory Add(PostCategory dto)
        {
            return _postCategoryRepository.Add(dto);
        }

        /// <summary>
        /// update record
        /// </summary>
        /// <param name="dto"></param>
        public void Update(PostCategory dto)
        {
            _postCategoryRepository.Update(dto);
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="dto"></param>
        public PostCategory Delete(PostCategory dto)
        {
            return _postCategoryRepository.Delete(dto);
        }

        /// <summary>
        /// get all records
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PostCategory> GetAll()
        {
            var rs = _postCategoryRepository.GetAll();
            return rs;
        }

        /// <summary>
        /// get all records and paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<PostCategory> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postCategoryRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get paging by parentID
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<PostCategory> GetPagingByParentID(int parentID, int page, int pageSize, out int totalRow)
        {
            return _postCategoryRepository.GetMultiPaging(x => x.Status && x.ParentID == parentID, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PostCategory GetByKey(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
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