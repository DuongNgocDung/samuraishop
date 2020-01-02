using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class PostTagService : IPostTagService
    {
        private IPostTagRepository _postTagRepository;
        private IUnitOfWork _unitOfWork;

        public PostTagService(IPostTagRepository postTagRepository, IUnitOfWork unitOfWork)
        {
            _postTagRepository = postTagRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public PostTag Add(PostTag dto)
        {
            return _postTagRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(PostTag dto)
        {
            _postTagRepository.Update(dto);
        }

        /// <summary>
        /// delete data
        /// </summary>
        /// <param name="dto"></param>
        public PostTag Delete(PostTag dto)
        {
            return _postTagRepository.Delete(dto);
        }

        /// <summary>
        /// get paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<PostTag> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postTagRepository.GetMultiPaging(x => x == x, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by key
        /// </summary>
        /// <param name="postID"></param>
        /// <param name="tagID"></param>
        /// <returns></returns>
        public PostTag GetByKey(int postID, string tagID)
        {
            return _postTagRepository.GetSingleById(new object[] { postID, tagID });
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