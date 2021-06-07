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
    class ErrorLoggerTests
    {
        
        // Example to test void methods 
        [Test]
        public void Log_WhenCalled_SetTheLastErrorPropertu()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        //Example of parameterized test for methods that throw exceptions
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();

            // Normally you would use this to arrange the test, but the method to be tested is written to throw exceptions so this will throw an error
            // logger.Log(error);

            // Example of how to use a delegate

            // This is a cleaner way to write the Assert section with built in helper functions
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);

             //Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<DivideByZeroException>);
        }
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            var id = Guid.Empty;

            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

    }
}
