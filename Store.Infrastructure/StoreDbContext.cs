using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure
{
  public class StoreDbContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GN4H313\\TECHNOTO;Initial Catalog=StoreDbContext;User Id=sa;Password=Am@13802;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }
    }
}
