using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IMenuGroupService
    {
        void Add(MenuGroup dto);

        void Update(MenuGroup dto);

        void Delete(MenuGroup dto);

        IEnumerable<MenuGroup> GetAllPaging(int page, int pageSize, out int totalRow);

        MenuGroup GetByKey(int id);

        void SaveChanges();
    }
}