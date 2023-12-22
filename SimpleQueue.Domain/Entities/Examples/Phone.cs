using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue.Domain.Entities.Examples
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Number { get; set; }

        #region Relations

        #region ...:::Type one student - many Phone:::..
       // public int StudentId { get; set; }
       //public Student Student { get; set; }

        #endregion

        #endregion
    }
}