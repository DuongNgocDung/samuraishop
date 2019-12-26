using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IPostService
    {
        void Add(Post dto);

        void Update(Post dto);

        void Delete(Post dto);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllPagingByTag(string tag, int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetPagingByCategoryID(int categoryID, int page, int pageSize, out int totalRow);

        Post GetByKey(int id);

        void SaveChanges();
    }
}
