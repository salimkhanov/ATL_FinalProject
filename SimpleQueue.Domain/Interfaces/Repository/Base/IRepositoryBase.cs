using SimpleQueue.Domain.Entities.Base;

namespace SimpleQueue.Domain.Interfaces.Repository.Base
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        #region Synchronous methods
        T FindById(int Id);
        IQueryable<T> FindAllActive();
        IQueryable<T> FindAll();
        IQueryable<T> FindAllActiveAsNoTracking(); //AsNoTracking
        IQueryable<T> FindAllAsNoTracking();
        void Create(T entity);
        int CreateWithReturnId(T entity);
        void CreateRange(IList<T> entites);
        void Update(T entity);
        void UpdateRange(IList<T> entity);
        void Deactivate(T entity);
        void Delete(T entity);
        void DeleteRange(IList<T> entity);
        #endregion

        #region extra
        //IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        //IQueryable<T> FindByConditionAsNoTracking(Expression<Func<T, bool>> expression);
        //T FindByConditionFirstOrDefaultAsNoTracking(Expression<Func<T, bool>> expression);
        #endregion
    }
}