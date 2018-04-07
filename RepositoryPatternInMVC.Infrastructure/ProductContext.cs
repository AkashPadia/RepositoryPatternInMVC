using RepositoryPatternInMVC.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternInMVC.Infrastructure
{
    class ProductContext: DbContext
    {
        public ProductContext():base("name=ProductAppConnectionString")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
