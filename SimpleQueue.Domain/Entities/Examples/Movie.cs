using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQueue.Domain.Entities.Examples
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public List<Genre> Genres { get; set; }
    }
}