using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_WhenCalledWithThree_ReturnsFizz()
        {
            //Arrange
            var fizzTest = new FizzBuzz();

            //Add
            var result = FizzBuzz.GetOutput(3);

            //Assert

            Assert.That(result, Is.EqualTo("Fizz"));

        }


        [Test]
        public void GetOutput_WhenCalledWithfive_ReturnsBuzz()
        {
            //Arrange
            var fizzTest = new FizzBuzz();

            //Add
            var result = FizzBuzz.GetOutput(5);

            //Assert

            Assert.That(result, Is.EqualTo("Buzz"));

        }


        [Test]
        public void GetOutput_WhenCalledWithThree_ReturnsFizzBuzz()
        {
            //Arrange
            var fizzTest = new FizzBuzz();

            //Add
            var result = FizzBuzz.GetOutput(15);

            //Assert

            Assert.That(result, Is.EqualTo("FizzBuzz"));

        }


        [Test]
        public void GetOutput_WhenCalledWithOne_One()
        {
            //Arrange
            var fizzTest = new FizzBuzz();

            //Add
            var result = FizzBuzz.GetOutput(1);

            //Assert

            Assert.That(result, Is.EqualTo("1"));

        }


        [Test]

        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(1, "1")]


        public void GetOutput_WhenCalledWithInput_ReturnsExpectedResult(int input, string expectedResult)
        {
            // This is not needed because the fizzbuzz method is static 
            //Arrange
            // var fizzTest = new FizzBuzz();

            //Add
            var result = FizzBuzz.GetOutput(input);

            //Assert

            Assert.That(result, Is.EqualTo(expectedResult));

        }


    }
}
