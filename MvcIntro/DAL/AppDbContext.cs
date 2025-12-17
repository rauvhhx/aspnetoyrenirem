using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MvcIntro.Models;

namespace MvcIntro.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }


    }
}
