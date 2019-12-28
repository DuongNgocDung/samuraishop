using Model.Models;

namespace Service.Interface
{
    public interface IErrorService
    {
        Error Add(Error dto);

        void SaveChanges();
    }
}