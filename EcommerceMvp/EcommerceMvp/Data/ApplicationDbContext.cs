using Microsoft.EntityFrameworkCore;
using EcommerceMvp.Models;


namespace EcommerceMvp.Data
{
 
	
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
        }
    }



