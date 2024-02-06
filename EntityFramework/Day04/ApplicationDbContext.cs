using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day04.Models;
using Microsoft.EntityFrameworkCore;

namespace Day04
{
    public class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=EfTestV4;Integrated Security=True;");
        }

        public DbSet<Stock> Stocks{ get; set; }
    }
}
