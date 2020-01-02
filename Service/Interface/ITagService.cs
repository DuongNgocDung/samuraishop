using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface ITagService
    {

        Tag Add(Tag dto);

        void Update(Tag dto);

        Tag Delete(Tag dto);

        IEnumerable<Tag> GetAllPaging(int page, int pageSize, out int totalRow);

        Tag GetByKey(string id);

        void SaveChanges();
    }
}