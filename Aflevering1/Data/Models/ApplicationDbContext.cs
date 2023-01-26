using Aflevering1.Models;
using Microsoft.EntityFrameworkCore;

namespace Aflevering1.Data.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
        public DbSet<Shoppinglist> ShoppingLists { get; set; }
    }
}
