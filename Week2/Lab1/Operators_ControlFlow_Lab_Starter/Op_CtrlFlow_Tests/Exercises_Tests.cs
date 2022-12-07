﻿using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {

        [Test]
        public void MyMethodTests()
        {
            Assert.That(Exercises.MyMethod(4, 1), Is.EqualTo(true));
            Assert.That(Exercises.MyMethod(1, 1), Is.EqualTo(false));
            Assert.That(Exercises.MyMethod(-27, 3), Is.EqualTo(true));
            Assert.That(Exercises.MyMethod(27, -3), Is.EqualTo(true));
            Assert.That(Exercises.MyMethod(7, 21), Is.EqualTo(false));
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
    }
}