using Moq;
using NUnit.Framework;
using TDDCalculator;

namespace TDDCalculatorTest
{
    [TestFixture]
    class StringCalculatorTest
    {
        [Test]
        public void AddEmptyTest()
        {
            int Expected = 0, Actual;
            StringCalculator sc = new StringCalculator();
            Actual = sc.Add("");
            Assert.AreEqual(Expected,Actual,"For empty failed.");
        }

        [Test]
        public void AddOneNumberTest()
        {
            int Expected = 3, Actual;
            StringCalculator sc = new StringCalculator();
            Actual = sc.Add("3");
            Assert.AreEqual(Expected, Actual, "For one number failed.");
        }

        [Test]
        public void AddTwoNumberTest()
        {
            int Expected = 5, Actual;
            StringCalculator sc = new StringCalculator();
            Actual = sc.Add("2,3");
            Assert.AreEqual(Expected, Actual, "For 2 numbers failed.");
        }

        [Test]
        public void AddNNumberTest()
        {
            int Expected = 10, Actual;
            StringCalculator sc = new StringCalculator();
            Actual = sc.Add("2,3,1,4");
            Assert.AreEqual(Expected, Actual, "For N numbers failed.");
        }

        [Test]
        public void AddNNumbernewLineTest()
        {
            int Expected = 10, Actual;
            StringCalculator sc = new StringCalculator();
            Actual = sc.Add("2,3\n1,4");
            Assert.AreEqual(Expected, Actual, "For N numbers newline failed.");
        }

        [Test]
        public void SubtractEmptyTest()
        {
            int Expected = 0, Actual;
            StringCalculator sc = new StringCalculator();
            Actual = sc.subtract("");
            Assert.AreEqual(Expected, Actual, "Subtract for empty failed.");
        }

        [Test]
        public void SubtractNullTest()
        {
            int Expected = 0, Actual;
            StringCalculator sc = new StringCalculator();
            Actual = sc.subtract(null);
            Assert.AreEqual(Expected, Actual, "Subtract for empty failed.");
        }

        [Test]
        public void MoqTest()
        {
            Mock<StringCalculator> mockStringCalculator;

            int Expected = 4, Actual;

            mockStringCalculator = new Mock<StringCalculator>(MockBehavior.Strict);
            mockStringCalculator.Setup(x => x.Add(null)).Returns(0);
            mockStringCalculator.Setup(x => x.Add("2,2")).Returns(4);

            StringCalculator sc = mockStringCalculator.Object;
            Actual = sc.Add("2,2");
            Assert.AreEqual(Expected, Actual, "Subtract for empty failed.");
        }

    }
}
