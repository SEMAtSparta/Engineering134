using NuGet.Frameworks;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }
        [Test]
        public void PlayingWithConstraints()
        {
            var subject = new Calculator { Num1 = 6 };
            Assert.That(subject.DivisibleBy3());

            subject.Num1 = 7;
            Assert.That(subject.DivisibleBy3, Is.False);
        }

        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            var expectedStr = "AdvancedNUnit.Calculator";
            Assert.That(subject.ToString, Is.EqualTo(expectedStr));
            Assert.That(subject.ToString, Does.Not.Contain("Potato").IgnoreCase);
            Assert.That(subject.ToString, Is.Not.Empty);
        }
        [Test]

        public void RangeConstraint()
        {
            var myDiceRolls = new List<int> { 6, 6 };
            Assert.That(myDiceRolls[0], Is.InRange(1, 6));
        }

        [Test]
        public void ArrayHasCount99()
        {
            int[] myArray = new int[99];
            Assert.That(myArray.Count, Is.EqualTo(99));
            //or
            Assert.That(myArray, Has.Length.EqualTo(99));
        }

        [Test]
        public void ArrayContainsTwoInRange1_10()
        {
            int[] myArray = { 5, 7, 22, 623 };
            
            Assert.That(myArray, Has.Exactly(2).InRange(1,10));
        }

        [Test]
        public void StringContainsChars()
        {
            string myString = "wordswords words";
            string targetString = "wor";

            Assert.That(myString, Does.StartWith(targetString).IgnoreCase);
        }
    }
    
}