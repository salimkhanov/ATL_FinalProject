using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue.Domain.Entities.Examples
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string Pin { get; set; }

        #region Relations

        #region ...:::Type one person - one document:::..

        public int StudentId { get; set; }
        public Student Student { get; set; }

        #endregion

        #endregion
    }
}