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
    }

    public class Kata
    {
        public static bool IsSquare(int n)
        {
            if (n > 0)
            {
                return true;
            }
            return false;
        }
    }
}
