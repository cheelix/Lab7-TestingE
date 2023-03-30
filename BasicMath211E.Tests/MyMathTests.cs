namespace BasicMath211E.Tests
{
    public class Tests
    {
        private MyMathOperations mathOperations;

        [SetUp]
        public void Setup()
        {
            this.mathOperations = new MyMathOperations();
        }

        [Test]
        public void TestAddingTwoPlusTwo()
        {
            double expected = 4;
            double actual = this.mathOperations.Add(2, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSubtractThreeFromFive()
        {
            double expected = 2;
            double actual = this.mathOperations.Subtract(5, 3);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCantDivideByZero()
        {
            try
            {
                double actual = this.mathOperations.Divide(10, 0);

                Assert.Fail();
            }
            catch (DivideByZeroException)
            {
                Assert.Pass();
            }
            


        }

        [Test]
        public void TestMultiplyThreeTimesFour()
        {
            double expected = 12;
            double actual = this.mathOperations.Multiply(3, 4);

            Assert.AreEqual(expected, actual);
        }







        [TearDown]
        public void Teardown()
        {
            this.mathOperations = null;
        }
    }
}