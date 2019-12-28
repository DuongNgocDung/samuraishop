using Data.Infrastructure;
using Model.Models;

namespace Data.Repositories.Interface
{
    /// <summary>
    /// kế thừa cái interface IRepository để lấy những phương thức base trong trỏng
    /// </summary>
    public interface IErrorRepository : IRepository<Error>
    {
    }
}