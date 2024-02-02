using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day03.Models;
using Microsoft.EntityFrameworkCore;

namespace Day03
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EfTestV3;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasOne(b => b.BlogImage)
                .WithOne(i => i.Blog)
                .HasForeignKey<BlogImage>(b => b.BlogForeignKey);

            // another way to create one to many relation without navigation prop
            modelBuilder.Entity<Post>()
                .HasOne<Blog>()
                .WithMany()
                .HasForeignKey(b => b.BlogId);

            // create many to many in fluent api
            /*modelBuilder.Entity<Post>()
                 .HasMany(e => e.Tags)
                 .WithMany(e => e.Posts)
                 .UsingEntity<PostTag>(
                     l => l.HasOne(e => e.Tag).WithMany(e => e.PostTags).HasForeignKey(e => e.TagId),
                     r => r.HasOne(e => e.Post).WithMany(e => e.PostTags).HasForeignKey(e => e.PostId),
                     pt =>
                     {
                         pt.Property(pt => pt.AddedOn).HasDefaultValueSql("GETDATE()");
                         pt.HasKey(pt => new { pt.PostId, pt.TagId });
                     }
                  );*/
            // indirect many to many
            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new { pt.PostId, pt.TagId });

            modelBuilder.Entity<PostTag>()
                .Property(e => e.AddedOn)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<PostTag>()
                .HasOne(e => e.Post)
                .WithMany(e => e.PostTags)
                .HasForeignKey(e => e.PostId);

            modelBuilder.Entity<PostTag>()
                .HasOne(e => e.Tag)
                .WithMany(e => e.PostTags)
                .HasForeignKey(e => e.TagId);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
    }

    public class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
