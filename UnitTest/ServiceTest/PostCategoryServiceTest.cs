using Data.Infrastructure;
using Data.Repositories;
using Data.Repositories.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Models;
using Moq;
using Service;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        IPostCategoryService _objService;

        List<PostCategory> listObj;

        /// <summary>
        /// Mục đích của cái mock này là tạo 1 đối tượng giả
        /// sau đó phần tham số truyền vào cho cái service thì mình chỉ cần mock.object là sẽ lấy được
        /// một INSTANCE của cái mock mới tạo giả đó
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _objService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            listObj = new List<PostCategory>()
            {
                new PostCategory(){Name = "Danh sách 1", Alias = "Category 1", Status = true},
                new PostCategory(){Name = "Danh sách 2", Alias = "Category 2", Status = true},
                new PostCategory(){Name = "Danh sách 3", Alias = "Category 3", Status = true}
            };
        }

        /// <summary>
        /// 1 hàm test mock như vậy sẽ có 3 bước: 
        /// SET UP METHOD - CALL ACTION - COMPARE
        /// </summary>
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //set up method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(listObj);

            //call action
            var result = _objService.GetAll() as List<PostCategory>;

            //compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void PostCategory_Service_Add()
        {
            PostCategory obj = new PostCategory()
            {
                Name = "ADD NEW",
                Alias = "Add New",
                Status = true
            };

            _mockRepository.Setup(m => m.Add(obj)).Returns((PostCategory p) =>
            {
                p.ID = 1;
                return p;
            });

            var result = _objService.Add(obj);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }

        [TestMethod]
        public void PostCategory_Service_Delete()
        {
            PostCategory obj = new PostCategory()
            {
                ID = 2,
                Name = "Xóa",
                Alias = "Delete",
                Status = true
            };

            _mockRepository.Setup(m => m.Delete(obj)).Returns((PostCategory p)=> { return null; });

            var result = _objService.Delete(obj);

            Assert.IsNull(result);
        }

        //[TestMethod]
        //public void PostCategory_Service_Update()
        //{
        //    PostCategory objAdd = new PostCategory()
        //    {
        //        Name = "Tạo mới",
        //        Alias = "Add",
        //        Status = true
        //    };
        //    PostCategory objUpdate = new PostCategory()
        //    {
        //        ID = 20,
        //        Name = "Cập nhật",
        //        Alias = "Update",
        //        Status = true
        //    };

        //    _mockRepository.Setup(m => m.Add(objAdd)).Returns((PostCategory p) =>
        //    {
        //        p.ID = 20;
        //        return p;
        //    });
        //    _mockRepository.Setup(m => m.Update(objUpdate));

        //    _objService.Update(objAdd);
        //    var rsAfterUpdate = _objService.GetByKey(20);
        //    Assert.AreEqual(objUpdate.Name, rsAfterUpdate.Name);
        //}
    }
}
