using RepositoryPatternInMVC.Core;
using RepositoryPatternInMVC.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternInMVC.Infrastructure
{
    class ProductRepository : IProductRepository
    {
        ProductContext _context = new ProductContext();

        public void Add(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
        }

        public void Edit(Product p)
        {
            _context.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }

        public Product FindById(int Id)
        {
            var result = (from r in _context.Products where r.Id == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable GetProducts()
        {
            return _context.Products;
        }

        public void Remove(int Id)
        {
            Product p = _context.Products.Find(Id);
            _context.Products.Remove(p);
            _context.SaveChanges();
        }
    }
}
