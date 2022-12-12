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
                Assert.That(result, Is.InRange(2,12));
            }            
        }

        [TestCase(1111)]
        [TestCase(2222)]
        [TestCase(9999)]

        public void GivenKnownSeed_RollDice_ReturnsCorrectValues(int seed)
        {
            Random rnd = new Random(seed);
            int value1 = rnd.Next(1,7);
            int value2 = rnd.Next(1,7);
            int result = value1 + value2;
            int methodOutput = Methods.RollDice(new Random(seed));
            Assert.That(methodOutput, Is.EqualTo(result));
        }

    }
}
