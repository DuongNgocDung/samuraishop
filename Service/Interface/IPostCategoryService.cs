using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory dto);

        void Update(PostCategory dto);

        PostCategory Delete(PostCategory dto);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<PostCategory> GetPagingByParentID(int parentID, int page, int pageSize, out int totalRow);

        PostCategory GetByKey(int id);

        void SaveChanges();
    }
}