using aspdotnetcoreMarioSamison.Entities;
using Microsoft.EntityFrameworkCore;

namespace aspdotnetcoreMarioSamison.Entities
{
    public interface IEntityContext
    {
        DbSet<Author> Authors { get; set; }
        DbSet<Book> Books { get; set; }
        DbSet<Genre> Genre { get; set; }
    }

    public class EntityContext : DbContext, IEntityContext
    {
        public EntityContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasKey(b => b.Id);
            modelBuilder.Entity<Book>().HasMany(b => b.Authors).WithOne(ba => ba.Book);
            modelBuilder.Entity<Book>().HasOne(b => b.Genre).WithMany(g => g.Books);

            modelBuilder.Entity<AuthorBook>().HasKey(ab => new { ab.AuthorId, ab.BookId });

            modelBuilder.Entity<Author>().HasKey(a => a.Id);
            modelBuilder.Entity<Author>().HasMany(b => b.Books).WithOne(ba => ba.Author);


            modelBuilder.Entity<Genre>().HasKey(b => b.Id);

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}
