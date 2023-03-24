using MathTesting;

namespace MathTest.Tests
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
        public void Test_AddMethod()
        {
            double expected = 4;
            double actual = this.mathOperations.Add(2, 2);

            Assert.AreEqual(expected, actual);
            
        }

        [Test]
        public void Test_SubtractMethod()
        {

            double expected = 0;
            double actual = this.mathOperations.Subtract(2, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_MultiplyMethod()
        {
            double expected = 4;
            double actual = this.mathOperations.Multiply(2, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_DivideMethod()
        {
            double expected = 1;
            double actual = this.mathOperations.Divide(2, 2);

            Assert.AreEqual(expected, actual);
        }

        [TearDown] 
        //resets the test environment
        public void TearDown()
        {
            this.mathOperations = null;
        }
    }
}