using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day01.Configuration;
using Day01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day01
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EfTest;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Blog>()
                .Property(m => m.Name)
                .IsRequired();*/

            new BlogEntityConfig().Configure(modelBuilder.Entity<Blog>());
            //another way to create entity
            modelBuilder.Entity<AuditEntry>();

            // another way to execlude class
            // modelBuilder.Ignore<Post>();

            // execlude table from all the coming migrations
            /* modelBuilder.Entity<Blog>()
                 .ToTable("Blogs", b => b.ExcludeFromMigrations());*/

            // another way to change table name
            modelBuilder.Entity<Post>()
                .ToTable("Posts");


        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
