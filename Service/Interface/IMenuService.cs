using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IMenuService
    {
        Menu Add(Menu dto);

        void Update(Menu dto);

        Menu Delete(Menu dto);

        IEnumerable<Menu> GetAllPaging(int page, int pageSize, out int totalRow);

        Menu GetByKey(int id);

        void SaveChanges();
    }
}