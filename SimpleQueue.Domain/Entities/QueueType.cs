using SimpleQueue.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleQueue.Domain.Entities
{
    /// <summary>
    /// Növbənin tipi (misal: Plastik kartlar, Ərizələr)
    /// </summary>
    [Table("QUEUE_TYPES")]
    public class QueueType : BaseEntity
    {
        public string? QueueIndexCharacter { get; set; } // PK-0001; PK-0075
        public bool WithPause { get; set; } // true or false
        public TimeSpan PauseStartTime { get; set; }
        public TimeSpan PauseStopTime { get; set; }
        public int OrderIndex { get; set; }
    }
}