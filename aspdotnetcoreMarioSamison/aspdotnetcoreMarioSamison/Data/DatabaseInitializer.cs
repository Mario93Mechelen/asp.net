using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspdotnetcoreMarioSamison.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace aspdotnetcoreMarioSamison.Data
{
    public class DatabaseInitializer
    {
        public static void InitializeDatabase(EntityContext entityContext)
        {
            entityContext.Database.EnsureCreated();

            var genres = new List<Genre>
            {
                new Genre() {Name = "Horror"},
                new Genre() {Name = "Romcom"},
                new Genre() {Name = "Klassieker"}
            };

            var authors = new List<Author>();
            for (var i = 0; i < 20; i++)
            {
                authors.Add(new Author { FirstName = $"Author First Name {i}", LastName = $"Author Last Name {i}" });
            }

            var books = new List<Book>();
            for (var i = 0; i < 20; i++)
            {
                var authorBook = new AuthorBook()
                {
                    Author = authors[i]
                };
                Genre genre = null;
                if (i % 4 == 0)
                {
                    genre = genres[0];
                }
                else if (i % 3 == 0)
                {
                    genre = genres[1];
                }
                else if (i % 2 == 0)
                {
                    genre = genres[2];
                }
                books.Add(new Book { Title = $"Book {i}", Authors = new List<AuthorBook> { authorBook }, Genre = genre, CreationDate = DateTime.Now.AddYears(-1).AddDays(i) });
            }

            var me = new Author { FirstName = "Raf", LastName = "Ceuls" };
            books[0].Authors.Add(new AuthorBook() { Author = me });

            entityContext.Genre.AddRange(genres);
            entityContext.Authors.AddRange(authors);
            entityContext.Books.AddRange(books);
            entityContext.SaveChanges();
        }
    }
}