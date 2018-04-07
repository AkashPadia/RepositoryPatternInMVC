using RepositoryPatternInMVC.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternInMVC.Infrastructure
{
    class ProductInitalizeDB : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new Product { Id = 1, Name = "Rice", inStock = true, Price = 30 });
            context.Products.Add(new Product { Id = 2, Name = "Sugar", inStock = false, Price = 40 });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
