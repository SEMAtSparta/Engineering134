﻿using NUnit.Framework;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    public class CheckInputTests
    {
        [TestCase("PASSWORD")]
        [TestCase("password")]
        [TestCase("PaSswORd")]
        public void GivenTheStringPassword_RegardlessOfCase_CheckInput_ReturnsTrue(string str )
        {
            bool result = Methods.CheckInput(str);
            Assert.IsTrue(result);
        }

        [TestCase("PASS")]
        [TestCase("word")]
        [TestCase("Chicken")]
        [TestCase("")]

        [TestCase("passwordpassword")]
        [TestCase("password1")]
        [TestCase("pass word")]

        public void GivenAnyStringExceptPassword_CheckInput_ReturnsFalse(string str)
        {
            bool result = Methods.CheckInput(str);
            Assert.IsFalse(result);
        }
    }
}
