using Model.Models;

namespace Service.Interface
{
    public interface IPageService
    {
        Page Add(Page dto);

        void Update(Page dto);

        Page Delete(Page dto);

        void SaveChanges();
    }
}