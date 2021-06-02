using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Fundamentals.Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Fundamentals.Math();
        }
        [Test]
        [Ignore("Because I want to show an example of how to ignore a test")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //Arrange
            // Used setup to create a new instance of Math for all these test so we no longer need to arrange this instance in the following tests
            // var math = new Fundamentals.Math();

            //Add
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        
        // Example of Parameterized Test with NUnit you can use this perform the 3 tests below in one block of code
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            //Arrange
           // var math = new Fundamentals.Math();

            //Add
            var result = _math.Max(2, 1);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            // Arrange
            // var math = new Fundamentals.Math();

            // Add
            var result = _math.Max(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(2));

        }
        [Test]
        public void Max_FirstArgumentIsEqual_ReturnSameArgument()
        {
            // Arrange
            // var math = new Fundamentals.Math();

            // Add
            var result = _math.Max(1, 1);

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }



    }
}
