using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue.Domain.Entities.Examples
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name1 { get; set; }
        public string FirstName { get; set; }

        #region Relations

        #region ...:::Type one student - one document:::..
        public Document Document { get; set; }

        #endregion

        #region ...:::Type one student - many Phone:::..
        public List<Phone> Phones { get; set; }

        #endregion



        #region ...:::Type many student - many cource:::..
        public ICollection<Cource> Cources { get; set; }

        #endregion

        #endregion
    }
}