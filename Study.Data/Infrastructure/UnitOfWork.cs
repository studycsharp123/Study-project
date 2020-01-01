using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private StudyDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public StudyDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Commit()
        {
            //save change la phuong thuc cua dbContext
            DbContext.SaveChanges();
        }
    }
}
