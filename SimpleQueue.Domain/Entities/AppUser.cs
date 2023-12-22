using Microsoft.AspNetCore.Identity;
using SimpleQueue.Domain.Entities.Base;

namespace SimpleQueue.Domain.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}