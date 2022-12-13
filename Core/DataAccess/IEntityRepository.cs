﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DateAccess
{
    public interface IEntityRepository<T> where T : class, IEntity , new()  
    {
        List<T> GetAll(Expression<Func<T,bool>> filder=null);

        T Get(Expression<Func<T, bool>> filder);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
  
    }
}
