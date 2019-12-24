using System;

namespace Data.Infrastructure
{
    /// <summary>
    /// cái interface IDisposable này (có sẵn của C#) cho phép những cái nào kế thừa từ nó có thể
    /// cài đặt các phương thức để TỰ ĐỘNG HỦY
    /// </summary>
    public class Disposable : IDisposable
    {
        private bool isDispose;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //thu hoạch bộ nhớ ??
        }

        private void Dispose(bool disposing)
        {
            if (!isDispose && disposing)
            {
                DisposeCore();
            }

            isDispose = true;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}