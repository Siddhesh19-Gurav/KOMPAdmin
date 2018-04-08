using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KOMP.Repository
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IQueryable<T> GetAll();
        void Edit(T entity);
        void Insert(T entity);
        void Delete(T entity);
    }
}