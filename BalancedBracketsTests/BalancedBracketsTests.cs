using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]

        public void TestBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]

        public void TestRightBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }

        [TestMethod]

        public void TestLeftBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]

        public void TestTextFull()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[JavaScript]"));
        }

        [TestMethod]

        public void TestText()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Java[Script]"));
        }

        [TestMethod]

        public void TestEmptyLeft()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]JavaScript"));
        }

        [TestMethod]

        public void TestBackwards()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]

        public void TestDoubleLeft()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
        }

        [TestMethod]

        public void TestDoubleRight()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }

        [TestMethod]

        public void TestTripleBack()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]]Java[[["));
        }

        [TestMethod]

        public void TestEmptyText()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
    }
}
