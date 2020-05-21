using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCRUDAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductCRUDAPP.Data
{
    public class ProductCRUDAPPContext : DbContext
    {
        public ProductCRUDAPPContext(DbContextOptions<ProductCRUDAPPContext> options)
            : base(options) { }
        public DbSet<Product> Product { get; set; }

    }
}
