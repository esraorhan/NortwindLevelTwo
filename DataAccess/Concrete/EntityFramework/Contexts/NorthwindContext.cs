using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ESRAORHAN;Database=Northwind;User Id=sa;Password=esra1905;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } //558. ders udemy
    }
}
