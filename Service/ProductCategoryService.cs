using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductCategoryService: IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            _productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="dto"></param>
        public ProductCategory Add(ProductCategory dto)
        {
            return _productCategoryRepository.Add(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(ProductCategory dto)
        {
            _productCategoryRepository.Update(dto);
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="dto"></param>
        public ProductCategory Delete(ProductCategory dto)
        {
            return _productCategoryRepository.Delete(dto);
        }

        /// <summary>
        /// get all records
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }

        /// <summary>
        /// get all paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            IEnumerable<ProductCategory> rs = _productCategoryRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
            return rs.OrderByDescending(x => x.CreateDate).ThenBy(x => x.ID);
        }

        /// <summary>
        /// get paging by parent ID
        /// </summary>
        /// <param name="parentID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<ProductCategory> GetPagingByParentID(int parentID, int page, int pageSize, out int totalRow)
        {
            return _productCategoryRepository.GetMultiPaging(x => x.Status && x.ParentID == parentID, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductCategory GetByKey(int id)
        {
            return _productCategoryRepository.GetSingleById(new object[] { id });
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
