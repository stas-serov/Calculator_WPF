using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab8;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        double actual, expected;
        [TestMethod]
        public void test_add()
        {
            expected = 9.5;
            actual = Operations.plus(6.4, 3.1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_sub()
        {
            expected = 50;
            actual = Operations.minus(60, 10);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_div()
        {
            expected = 3;
            actual = Operations.div(9, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_mul()
        {
            expected = 90;
            actual = Operations.mul(30, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_root()
        {
            expected = 7;
            actual = Operations.root(49);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_square()
        {
            expected = 25;
            actual = Operations.square(5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_sin()
        {
            expected = 0;
            actual = Operations.sin(0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_cos()
        {
            expected = -1;
            actual = Operations.cos(180);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_one_div_x()
        {
            expected = 0.2;
            actual = Operations.one_div_x(5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void test_fact()
        {
            expected = 24;
            actual = Operations.fact(4);
            Assert.AreEqual(expected, actual);
        }
    }
}
