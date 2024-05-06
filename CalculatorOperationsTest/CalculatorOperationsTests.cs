using NUnit.Framework;
using CalculatorApp;

namespace CalculatorOperationsTest
{
    [TestFixture]
    public class CalculatorOperationsTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void AdditionTestReturnsCorrectSum()
        {
            // Arrange
            int num1 = 5, num2 = 3;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }
    }
}