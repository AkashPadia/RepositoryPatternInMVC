using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPatternInMVC.Core;
using RepositoryPatternInMVC.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternInMVC.Tests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository Repo;
        [TestInitialize]
        public void TestSetup()
        {
            ProductInitalizeDB db = new ProductInitalizeDB();
            System.Data.Entity.Database.SetInitializer(db);
            Repo = new ProductRepository();
        }

        [TestMethod]
        public void IsRepositoryInitalizeWithValidNumberOfData()
        {
            var result = Repo.GetProducts();
            Assert.IsNotNull(result);
            var numberOfRecords = result.Cast<Product>().ToList().Count;
            Assert.AreEqual(2, numberOfRecords);
        }

        [TestMethod]
        public void IsRepositoryAddsProduct()
        {
            Product productToInsert = new Product
            {
                Id = 3,
                inStock = true,
                Name = "Salt",
                Price = 17

            };

            Repo.Add(productToInsert);
            // If Product inserts successfully, 
            //number of records will increase to 3 
            var result = Repo.GetProducts();
            var numberOfRecords = result.Cast<Product>().ToList().Count;
            Assert.AreEqual(3, numberOfRecords);
        }

    }
}
