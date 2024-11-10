﻿using System.Linq.Expressions;

namespace E_TicktsCinma.Repository.IRepository
{
    public interface IRepository<T>where T : class
    {
        IQueryable<T> GetAll(string? include = null);

        T? GetOne(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void Edit(T entity);

        void Delete(T entity);

        void Commit();
    }
}
