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
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            // This is a very general test and may not be the best way to test an array 
            // Assert.That(result, Is.Not.Empty);

            // This is less general
            // Assert.That(result.Count(), Is.EqualTo(3));

            // Instead of the either of the above methods you could use the block below with 3 assert methods to be even more specific 
            // Assert.That(result, Does.Contain(1));
            // Assert.That(result, Does.Contain(3));
            // Assert.That(result, Does.Contain(5));

            //The above can also be expressed this way
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5, }));

            // Other useful tests for arrays and collections
            // Assert.That(result, Is.Ordered);
            // Assert.That(result, Is.Unique);
        }
        // test for limit that is negative number
        // test for limit that is zero




    }
}
