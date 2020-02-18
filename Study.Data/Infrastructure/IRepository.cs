using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Study.Data.Infrastructure
{
    //su dung de dinh nghia cac phuong thuc (method)
    // T: dai dien cho 1 kieu, o day T duoc dai dien cho class (where T : class)
    public interface IRepository<T> where T : class
    {
        //marks as entity as new
        void Add(T entity);
        //marks an entity as modified
        void Update(T entity);
        //marks an entity to be removed
        void Delete(T entity);
        void Delete(Guid Id);
        //delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);
        //get an entity by int Id
        T GetSingleById(Guid Id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);
        //includes muc dich de them cac bang con
        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}
