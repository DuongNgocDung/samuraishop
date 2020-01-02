using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class ProductTagService : IProductTagService
    {
        private IProductTagRepository _productTagRepository;
        private IUnitOfWork _unitOfWork;

        public ProductTagService(IProductTagRepository productTagRepository, IUnitOfWork unitOfWork)
        {
            _productTagRepository = productTagRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add new
        /// </summary>
        /// <param name="dto"></param>
        public ProductTag Add(ProductTag dto)
        {
            return _productTagRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(ProductTag dto)
        {
            _productTagRepository.Update(dto);
        }

        /// <summary>
        /// delete data
        /// </summary>
        /// <param name="dto"></param>
        public ProductTag Delete(ProductTag dto)
        {
            return _productTagRepository.Delete(dto);
        }

        /// <summary>
        /// get paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<ProductTag> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productTagRepository.GetMultiPaging(x => x == x, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by key
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="tagID"></param>
        /// <returns></returns>
        public ProductTag GetByKey(int productID, string tagID)
        {
            return _productTagRepository.GetSingleById(new object[] { productID, tagID });
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