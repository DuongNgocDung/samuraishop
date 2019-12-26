using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IPostTagService
    {
        void Add(PostTag dto);

        void Update(PostTag dto);

        void Delete(PostTag dto);

        IEnumerable<PostTag> GetAllPaging(int page, int pageSize, out int totalRow);

        void SaveChanges();
    }
}