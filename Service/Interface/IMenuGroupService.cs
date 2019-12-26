using Model.Models;
using System.Collections.Generic;

namespace Service.Interface
{
    public interface IMenuGroupService
    {
        MenuGroup Add(MenuGroup dto);

        void Update(MenuGroup dto);

        MenuGroup Delete(MenuGroup dto);

        IEnumerable<MenuGroup> GetAllPaging(int page, int pageSize, out int totalRow);

        MenuGroup GetByKey(int id);

        void SaveChanges();
    }
}