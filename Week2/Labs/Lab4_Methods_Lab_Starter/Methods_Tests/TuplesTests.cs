using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }

        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(4, 16, 64, 2)]
        [TestCase(1, 1, 1, 1)]
        [TestCase(0,0,0,0)]
        public void GivenANumber_PowersRoot_ReturnsCorrectOutput(int input, int square, int cube, double sqrt)
        {
            var output = Methods.PowersRoot(input);
            Assert.That(output.square, Is.EqualTo(square));
            Assert.That(output.cube, Is.EqualTo(cube));
            Assert.That(output.sqrt, Is.EqualTo(sqrt));
        }

        [Test]
        public void GivenANegativeNumber_PowersRoot_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => Methods.PowersRoot(-1), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Input cannot be negative."));
        }
        [Test]
        public void GivenALargeNumber_PowersRoot_ThrowsOverFlowException()
        {
            Assert.That(() => Methods.PowersRoot(int.MaxValue), Throws.TypeOf<OverflowException>());
        }

        [TestCase(2,3)]
        [TestCase(3,2)]
        [TestCase(5,87)]

        public void GivenTwoNumbers_Swap_SwapsNumbers(int a, int b)
        {
            int first = a;
            int second = b;
            Methods.Swap(ref a, ref b);
            Assert.That(first, Is.EqualTo(b));
            Assert.That(second, Is.EqualTo(a));
        }
    }
}