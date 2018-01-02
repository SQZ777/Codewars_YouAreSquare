using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_YouAreSquare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_0_Should_Be_False()
        {
            Assert.IsFalse(Kata.IsSquare(0));
        }

        [TestMethod]
        public void Input_1_Should_Be_true()
        {
            Assert.IsTrue(Kata.IsSquare(1));
        }

        [TestMethod]
        public void Input_2_Should_Be_False()
        {
            Assert.IsFalse(Kata.IsSquare(2));
        }

        [TestMethod]
        public void Input_4_Should_Be_True()
        {
            Assert.IsTrue(Kata.IsSquare(4));
        }

    }

    public class Kata
    {
        public static bool IsSquare(int n)
        {
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                if (i * i == n)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
