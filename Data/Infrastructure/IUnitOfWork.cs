namespace Data.Infrastructure
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Phương thức commit cho UnitOfWork
        /// </summary>
        void Commit();
    }
}