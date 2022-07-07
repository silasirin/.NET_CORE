//tamami version 5.0.3 olarak yuklendi. Cunku .net 5 ile latest version'lar uyumlu degil.
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using NetCoreCodeFirst.Models.Entity;

namespace NetCoreCodeFirst.Models.Context
{
    public class ApplicationDbContext: DbContext
    {
        //service'te tanimlanan base islemi al, options'a gonder (buradaki options DbContext'in kendisi, base de service'in kendisidir): 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
