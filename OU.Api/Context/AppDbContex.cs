using Microsoft.EntityFrameworkCore;
using OU.Api.Entities;

namespace OU.Api.Context
{
    public class AppDbContex : DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options) 
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
