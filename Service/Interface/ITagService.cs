using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface ITagService
    {

        void Add(Tag dto);

        void Update(Tag dto);

        void Delete(Tag dto);

        IEnumerable<Tag> GetAllPaging(int page, int pageSize, out int totalRow);

        void SaveChanges();
    }
}