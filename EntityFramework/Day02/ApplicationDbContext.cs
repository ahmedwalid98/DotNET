using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day02.Models2;
using Microsoft.EntityFrameworkCore;

namespace Day02
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EfTestV2;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set primary key in fluent api way
            /*modelBuilder.Entity<Book>()
                .HasKey(b => b.BookKey)
                .HasName("PK_BookKey")*/; // to set custome name
            // set composit key
            modelBuilder.Entity<Book>()
                .HasKey(b => new { b.Author, b.BookName });

            // set default value
            modelBuilder.Entity<Book>()
                .Property(b => b.Rating)
                .HasDefaultValue(2);

            // created computed column
            modelBuilder.Entity<Author>()
                .Property(a => a.DisplayName)
                .HasComputedColumnSql("[LastName] + ', ' + [FirstName]");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
