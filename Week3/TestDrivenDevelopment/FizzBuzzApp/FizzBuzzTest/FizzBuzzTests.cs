using FizzBuzzApp;

namespace FizzBuzzTests
{
    public class Tests
    {
        /*Requirements
         * given 1 returns 1
         * Takes in an input of maximum value
         * given 2 returns 1 and 2;
         * given maximum value return all numbers in a row up to some value
         * 
         * Prints output
         */

        [Test]
        public void Given1_FizzBuzz_Returns1()
        {
            //arrange
            int maxValue = 1;
            //act
            string output = Program.FizzBuzz(maxValue);
            string expectedValue = "1";
            //assert
            Assert.That(output, Is.EqualTo(expectedValue));
        }

        [Test]
        public void Given2_FizzBuzz_Returns1AndThen2()
        {
            //arrange
            int maxValue = 2;
            //act
            string output = Program.FizzBuzz(maxValue);
            string expectedValue = "1 2";
            //assert
            Assert.That(output, Is.EqualTo(expectedValue));
        }

        [Test]
        public void Given3_FizzBuzz_Returns12Fizz()
        {
            //arrange
            int maxValue = 3;

            //act
            string output = Program.FizzBuzz(maxValue);
            string expectedValue = "1 2 Fizz";

            //assert
            Assert.That(output, Is.EqualTo(expectedValue));
        }

        //incompatible test must be ignored
        //[Ignore("Invalid")]
        [Test]
        public void GivenMaxValue_FizzBuzz_ReturnsAllNumbersInARow()
        {
            //arrange
            int maxValue = 10;
            //act
            string output = Program.FizzBuzz(maxValue);
            string expectedValue = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz";

            Assert.That(output, Is.EqualTo(expectedValue));
        }

        [Test]
        public void Given5_FizzBuzz_Returns12Fizz4Buzz()
        {
            //arrange
            int maxValue = 5;

            //act
            string output = Program.FizzBuzz(maxValue);
            string expectedValue = "1 2 Fizz 4 Buzz";

            //assert
            Assert.That(output, Is.EqualTo(expectedValue));
        }

        [Test]
        public void Given15_FizzBuzz_ReturnsFizzBuzz()
        {
            //arrange
            int maxValue = 15;

            //act
            string output = Program.FizzBuzz(maxValue);
            string expectedValue = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";

            //assert
            Assert.That(output, Is.EqualTo(expectedValue));
        }
    }
}