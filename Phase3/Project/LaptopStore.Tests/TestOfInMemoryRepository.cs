using LaptopStore.Models;
using LaptopStore.Repositories;
using NUnit.Framework;
using System;
using System.Linq;

namespace LaptopStore.Tests
{
    [TestFixture]
    public class TestOfInMemoryRepository
    {
        [Test]
        public void TestGetAll()
        {
            var repository = new InMemoryProductsRepository();
            var products = repository.GetAllAsync().Result;

            Assert.NotNull(products);
            Assert.That(products.Count(), Is.GreaterThan(0));
            Assert.That(products.First().Name, Is.EqualTo("XPS15"));

        }

        [Test]
        public void TestFindAsync()
        {
            var repository = new InMemoryProductsRepository();
            var product = repository.FindAsync(2).Result;

            Assert.NotNull(product);
            Assert.That(product.ID, Is.EqualTo(2));
        }

        [Test]
        public void TestAddNewProduct()
        {
            var repository = new InMemoryProductsRepository();
            var product = new Product()
            {
                ID = 0,
                Name = "My laptop"
            };

            repository.Add(product);

            Assert.That(repository.NewProductsToAdd.Count(), Is.EqualTo(1));

            repository.SaveChangesAsync();
            Assert.That(repository.NewProductsToAdd.Count(), Is.EqualTo(0)); 
            Assert.That(InMemoryProductsRepository.Products.Count(), Is.EqualTo(3));

            Assert.That(product.ID, Is.GreaterThan(0));
        }


    }
}
