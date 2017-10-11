using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bibliotheek.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bibliotheek.Models
{
    public class BookEditDetailViewModel
    {
        [Required]
        public string Title { get; set; }
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$")]
        public string ISBN { get; set; }
        public DateTime CreationDate { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }
        public int? GenreId { get; set; }
        public List<SelectListItem> Genres { get; set; }

    }
}