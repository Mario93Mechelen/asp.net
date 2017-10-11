using System;
using Bibliotheek.Entities;

namespace Bibliotheek.Models
{
    public class BookDetailViewModel
    {
        public string ISBN;
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime CreationDate { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
    }
}