using SimpleQueue.Domain.Entities;
using SimpleQueue.Domain.Interfaces.Repository;
using SimpleQueue.Infrastructure.Repositories.Base;
using SimpleQueue.Persistence.EFContext;

namespace SimpleQueue.Infrastructure.Repositories
{
    public class QueueTypeRepository : EFRepositoryBase<QueueType>, IQueueTypeRepository
    {
        public QueueTypeRepository(EFIdentityCustomContext context) : base(context)
        {
        }
    }
}