using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue.Domain.Entities
{
    public class TestModelForExample
    {
        [Key]
        public int RowId { get; set; }
        public string Name { get; set; }        
        public int IntField { get; set; }
        [NotMapped]
        public string Description { get; set; }
    }
}