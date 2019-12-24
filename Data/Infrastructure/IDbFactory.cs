using System;

namespace Data.Infrastructure
{
    /// <summary>
    /// một cái giao tiếp để khởi tạo các đối tượng entity
    /// chúng ta ko khởi tạo trực típ mà thông qua cái này
    /// </summary>
    public interface IDbFactory : IDisposable
    {
        /// <summary>
        /// Chỉ cần 1 phương thức để init cái DbContext
        /// </summary>
        /// <returns></returns>
        SamuraiShopDbContext Init();
    }
}