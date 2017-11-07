using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspdotnetcoreMarioSamison.Models;
using aspdotnetcoreMarioSamison.Entities;
using aspdotnetcoreMarioSamison.Services;
using aspdotnetcoreMarioSamison.Data;
using Microsoft.EntityFrameworkCore;

namespace aspdotnetcoreMarioSamison.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        List<Genre> GetAllGenres();
        Genre GetGenreById(int id);
        void Persist(Book book);
        void Delete(int id);
    }
}
