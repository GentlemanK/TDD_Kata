using System;
using NUnit.Framework;
using TDDCalculator;

namespace TDDCalculatorTest
{
    [TestFixture]
    public class ClassForNUnitTest
    {
        [Test]
        public void TestMethodSum()
        {
            int actual, expected = 30;
            ClassForNUnit target = new ClassForNUnit();
            actual = target.Sum(12, 18);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestMethodSubt()
        {
            int actual, expected = 10;
            ClassForNUnit target = new ClassForNUnit();
            actual = target.Subt(10, 0);
            Assert.AreEqual(expected, actual);
        }
    }
}
