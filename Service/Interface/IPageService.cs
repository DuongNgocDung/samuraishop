using Model.Models;

namespace Service.Interface
{
    public interface IPageService
    {
        void Add(Page dto);

        void Update(Page dto);

        void Delete(Page dto);

        void SaveChanges();
    }
}