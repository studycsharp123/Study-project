using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Data.Infrastructure
{
     //tu tat cac doi tuong khi khong dung den
    //cac thanh phan ke thua tu IDisposable co the tu cai dat de huy cac method
    public class Disposable : IDisposable
    {
        private bool isDisposed;
        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing) {
                DisposeCore();
            }
            isDisposed = true;          
        }
        //override to this dispose custom objects
        protected virtual void DisposeCore()
        { 
        }
    }
}
