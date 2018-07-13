using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebApp.BLL.Interfaces
{
    public interface ICanGetAll<T>
    {
        IEnumerable<T> GetAll();
    }
    public interface ICanGetByID<TEntity>
    {
        TEntity GetByID(int id);
    }
    public interface ICanDelete<T>
    {
        void Delete(T entity);
    }
    public interface ICanSave<T>
    {
        T Save(T entity);
    }
    public interface ICanSaveWithLog<T>
    {
        T SaveWithLog(T entity);
    }
    public interface ICanCreate<T>
    {
        T Create();
    }
    public interface ICanGetCount
    {
        int GetCount();
    }
    public interface ICanGetListByFK<TEntity>
    {
        IEnumerable<TEntity> GetListByFK(int id);
    }
    public interface ICanSearch<TEntity>
    {
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> query);
    }
    public interface ICanLoadProperty<TEntity>
    {
        void LoadProperty<TElement>(TEntity entity, Expression<Func<TEntity, ICollection<TElement>>> navigationProperty, Expression<Func<TElement, bool>> predicate) where TElement : class;
    }
    public interface ICanQueryable<TEntity>
    {
        IQueryable<TEntity> Query();
    }
}
