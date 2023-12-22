using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue.Domain.Entities.Examples
{
    public class Cource
    {
        public int CourceId { get; set; }
        public string Name { get; set; }



        #region Relations

        #region ...:::Type many cource - many student:::..
        public List<Student> Students { get; set; }

        #endregion

        #endregion
    }
}
