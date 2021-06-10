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
    class DemeritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemeritPoints_WhenCalledWithSpeedAboveMax_ThrowsError()
        {
            var pointsCalculator = new DemeritPointsCalculator();


            Assert.That(() => pointsCalculator.CalculateDemeritPoints(301),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }

        [Test]
        public void CalculateDemeritPoints_WhenCalledWithSpeedBelowMin_ThrowsError()
        {
            var pointsCalculator = new DemeritPointsCalculator();            

            Assert.That(() => pointsCalculator.CalculateDemeritPoints(-1),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }

        //This is a parameterized test to handle the same cases as the two tests above.

        [Test]
        [TestCase(-1)]
        [TestCase(301)]

        public void CalculateDemeritPoints_WhenOutofRangeSpeedIsEntered_ThrowsError(int crazySpeed)
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(crazySpeed),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(69, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]

        public void CalculateDemeritPoints_WhenCalledWithSpeedLimit_ReturnsDemeritPoints( int speedLimt, int demeritPoints)
        {
            var pointsCalculator = new DemeritPointsCalculator();

            var result = pointsCalculator.CalculateDemeritPoints(speedLimt);

            Assert.That(result, Is.EqualTo(demeritPoints));
        }


    // This is a method that tests a single parameter the test above is better because it tests multiple parameters with a single method
      /* [Test]
        public void CalculateDemeritPoints_WhenCalledWithSpeedLimitPlusFive_ReturnsOneDemeritPoint()
        {
            var pointsCalculator = new DemeritPointsCalculator();
            
            var result = pointsCalculator.CalculateDemeritPoints(70);

            Assert.That(result, Is.EqualTo(1));
        }
      */

    }
}
