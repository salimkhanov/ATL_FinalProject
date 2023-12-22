using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleQueue.Domain.Entities;

namespace SimpleQueue.Persistence.EFContext
{
    public class EFIdentityCustomContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EFIdentityCustomContext(DbContextOptions<EFIdentityCustomContext> options) : base(options)
        {
        }


        #region ...::Dbset's::...
        public DbSet<QueueType> QueueTypes { get; set; }
        #endregion
    }
}