using Data.Infrastructure;
using Data.Repositories.Interface;
using Model.Models;
using Service.Interface;
using System.Collections.Generic;

namespace Service
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// cái này nó sẽ tự tiêm vô (service) (injection)
        /// </summary>
        /// <param name="productRepository"></param>
        /// <param name="unitOfWork"></param>
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="dto"></param>
        public Product Add(Product dto)
        {
            return _productRepository.Add(dto);
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="dto"></param>
        public Product Delete(Product dto)
        {
            return _productRepository.Delete(dto);
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="dto"></param>
        public void Update(Product dto)
        {
            _productRepository.Update(dto);
        }

        /// <summary>
        /// Get all records of Products and also get record of productCategory
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAll()
        {           
            return _productRepository.GetAll(new string[] { "ProductCategory" });
        }

        /// <summary>
        /// Get all and paging
        /// </summary>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        /// <summary>
        /// Get all paging by tag
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetAllPagingByTag(string tag, int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPagingByTag(tag, page, pageSize, out totalRow);
        }

        /// <summary>
        /// get paging by category ID
        /// </summary>
        /// <param name="categoryID"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalRow"></param>
        /// <returns></returns>
        public IEnumerable<Product> GetPagingByCategoryID(int categoryID, int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryID, out totalRow, page, pageSize);
        }

        /// <summary>
        /// get by key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetByKey(int id)
        {
            return _productRepository.GetSingleById(new object[] { id });
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