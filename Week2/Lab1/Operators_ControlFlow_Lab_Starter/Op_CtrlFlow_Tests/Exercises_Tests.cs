using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {

        [TestCase(4,1,true)]
        [TestCase(1, 1, false)]
        [TestCase(27, 3, true)]
        [TestCase(-27, 3, true)]
        [TestCase(7, 21, false)]
            
        public void MyMethod_ReturnsValid(int x, int y, bool b)
        {
            bool result = Exercises.MyMethod(x, y);
            Assert.That(result, Is.EqualTo(b));
        }

        [Test]
        public void MyMethod_ThrowsDivideByZero() 
        {
            Assert.That(() => Exercises.MyMethod(1, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void WhenMyMethod_FirstArgIs0_ThrowsArgumentOutOfRange()
        {
            Assert.That(() => Exercises.MyMethod(0,1), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenTicketType_AgeLessThan0_ThrowsArgumentOutOfRange()
        {
            Assert.That(() => Exercises.TicketType(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(0, "Fail.")]
        [TestCase(15, "Fail.")]
        [TestCase(39, "Fail.")]
        [TestCase(40, "Pass.")]
        [TestCase(50, "Pass.")]
        [TestCase(59, "Pass.")]
        [TestCase(60, "Pass with Merit.")]
        [TestCase(70, "Pass with Merit.")]
        [TestCase(74, "Pass with Merit.")]
        [TestCase(75, "Pass with Distinction.")]
        [TestCase(85, "Pass with Distinction.")]
        [TestCase(100, "Pass with Distinction.")]

        public void Grade_RangeTest(int mark, string expected)
        {
            var result = Exercises.Grade(mark);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void WhenGrade_MarkLessThan0_ThrowsArgumentOutOfRange()
        {
            Assert.That(() => Exercises.Grade(-1), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

    }
}
