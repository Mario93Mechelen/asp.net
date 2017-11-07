using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspdotnetcoreMarioSamison.Entities;

namespace aspdotnetcoreMarioSamison.Models
{
    public class BookListViewModel
    {
        public List<BookDetailViewModel> Books { get; set; }
        public DateTime GeneratedAt => DateTime.Now;
    }
}
