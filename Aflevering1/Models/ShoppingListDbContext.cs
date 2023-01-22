using Microsoft.EntityFrameworkCore;

namespace Aflevering1.Models
{
    public class ShoppingListDbContext: DbContext
    {
        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options) : base(options) { }
        public DbSet<Shoppinglist> ShoppingLists { get; set; }
    }
}
