using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [Test]
        public void RollDice_ReturnsWithinRange()
        {
            for(int i = 0; i< 30; i++)
            {
                int result = Methods.RollDice(new Random());
                Assert.That(result, Is.LessThanOrEqualTo(12));
                Assert.That(result, Is.GreaterThanOrEqualTo(2));
            }            
        }

        [TestCase(1111, 6)]
        [TestCase(2222, 9)]
        [TestCase(9999, 8)]

        public void GivenKnownSeed_RollDice_ReturnsCorrectValues(int seed, int expectedOutput)
        {
            int result = Methods.RollDice(new Random(seed));
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

    }
}
