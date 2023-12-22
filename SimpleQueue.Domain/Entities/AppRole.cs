using Microsoft.AspNetCore.Identity;
using SimpleQueue.Domain.Entities.Base;

namespace SimpleQueue.Domain.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}