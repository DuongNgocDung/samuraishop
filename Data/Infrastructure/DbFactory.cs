namespace Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SamuraiShopDbContext dbContext;

        /// <summary>
        /// nếu cái dbContext null thì tạo mới, ko thì thôi
        /// </summary>
        /// <returns></returns>
        public SamuraiShopDbContext Init()
        {
            return dbContext ?? (dbContext = new SamuraiShopDbContext());
        }

        /// <summary>
        /// hàm hủy, nếu khác null thì hủy
        /// </summary>
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}