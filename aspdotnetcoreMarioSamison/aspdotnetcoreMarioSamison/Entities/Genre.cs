using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspdotnetcoreMarioSamison.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}
