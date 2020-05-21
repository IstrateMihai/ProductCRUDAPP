using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCRUDAPP.Models;
using ProductCRUDAPP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ProductCRUDAPP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using var context = new ProductCRUDAPPContext(serviceProvider.GetRequiredService<DbContextOptions<ProductCRUDAPPContext>>());
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
            context.Product.AddRange(
                new Product
                {
                    Name = "Apple",
                    Price = 2,
                    Quantity = 1

                },
                new Product
                {
                    Name = "Orange",
                    Price = 3,
                    Quantity = 2
                },
                new Product
                {
                    Name = "Banana",
                    Price = 5,
                    Quantity = 4
                }


                );
            context.SaveChanges();
            // Look for any movies.


        }
        
    }
    
}
