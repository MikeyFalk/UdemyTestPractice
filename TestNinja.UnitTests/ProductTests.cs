using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests
{
    [TestFixture]

    class ProductTests
    {
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var product = new Product { ListPrice = 100 };

            var result = product.GetPrice(new Customer { IsGold = true });

            Assert.That(result, Is.EqualTo(70));
        }


        // Example of an abuse of mock when writing unit tests. The above test is much more simple and cleaner tests should be 3 -5 lines of code

      /*  [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount2()
        {
            var customer = new Mock<ICustomer>();
            customer.Setup(c => c.IsGold).Returns(true);
           
            var product = new Product { ListPrice = 100 };

            var result = product.GetPrice(customer.Object);

            Assert.That(result, Is.EqualTo(70));
        }
      */
    }
}
