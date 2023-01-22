using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Aflevering1.Models
{
    public class ShoppingListDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new ShoppingListDbContext(serviceProvider.GetRequiredService<DbContextOptions<ShoppingListDbContext>>());

            // Look for any todos.
            if (context.ShoppingLists.Any())
            {
                //if we get here then the data already seeded
                return;
            }
            context.ShoppingLists.AddRange(
                new Shoppinglist
                {
                    Id = 1,
                    ItemName = "Milk",
                    Quantity = 1,
                    Unit = Units.Liter,
                    Area = ShopArea.Dairy
                },
                new Shoppinglist
                {
                    Id = 2,
                    ItemName = "Chili Beans",
                    Quantity = 12,
                    Unit = Units.Pcs,
                    Area = ShopArea.CannedFood
                },
                new Shoppinglist
                {
                    Id = 3,
                    ItemName = "Peas",
                    Quantity = 1,
                    Unit = Units.Pcs,
                    Area = ShopArea.Frost
                },
                new Shoppinglist
                {
                    Id = 4,
                    ItemName = "Apple",
                    Quantity = 3,
                    Unit = Units.Pcs,
                    Area = ShopArea.FruitAndVegetables
                }
            ); 
            
            context.SaveChanges();

        }
    }
}
