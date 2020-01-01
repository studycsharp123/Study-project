using Study.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Data
{
    public class DbFactory : Disposable, IDbFactory
    {
        private StudyDbContext dbContext;
        //kiem tra neu null thi khoi tao 1 doi tuong StudyDbContext
        public StudyDbContext Init()
        {
            return dbContext ?? (dbContext = new StudyDbContext());

        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
