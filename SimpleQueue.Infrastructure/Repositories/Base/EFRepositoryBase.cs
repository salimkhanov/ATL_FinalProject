using SimpleQueue.Domain.Entities.Base;
using SimpleQueue.Domain.Interfaces.Repository.Base;
using SimpleQueue.Persistence.EFContext;

namespace SimpleQueue.Infrastructure.Repositories.Base
{
    public class EFRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        protected readonly EFIdentityCustomContext efDB;
        public EFRepositoryBase(EFIdentityCustomContext applicationIdentityContext)
        {
            efDB = applicationIdentityContext;
        }
        public void Create(TEntity entity)
        {
            efDB.Set<TEntity>().Add(entity);
            efDB.SaveChanges();
        }
        public void CreateRange(IList<TEntity> entites)
        {
            throw new NotImplementedException();
        }
        public int CreateWithReturnId(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public void Deactivate(TEntity entity)
        {
            entity.Status = EntityStatus.Inactive;
            efDB.Set<TEntity>().Update(entity);
            efDB.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                efDB.Remove(entity);
                efDB.SaveChanges();
            }
        }
        public void DeleteRange(IList<TEntity> entity)
        {
            throw new NotImplementedException();
        }
        public IQueryable<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }
        public IQueryable<TEntity> FindAllActive()
        {
            IQueryable<TEntity> entities;
            entities = efDB.Set<TEntity>().
                Where(x => x.Status == EntityStatus.Active);
            return entities;
        }
        public IQueryable<TEntity> FindAllActiveAsNoTracking()
        {
            throw new NotImplementedException();
        }
        public IQueryable<TEntity> FindAllAsNoTracking()
        {
            throw new NotImplementedException();
        }
        public TEntity FindById(int Id)
        {
            TEntity entity;
            entity = efDB.Set<TEntity>().Find(Id);
            return entity;
        }
        public void Update(TEntity entity)
        {
            efDB.Set<TEntity>().Update(entity);
            efDB.SaveChanges();
        }
        public void UpdateRange(IList<TEntity> entity)
        {
            throw new NotImplementedException();
        }
    }
}