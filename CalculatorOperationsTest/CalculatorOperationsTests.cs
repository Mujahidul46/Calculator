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
        public void AdditionTestReturnsCorrectSum() {
            // Arrange
            int num1 = 5, num2 = 3;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void SubtractionTestReturnsCorrectDifference() {
            // Arrange
            int num1 = 10, num2 = 4;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void MultiplicationTestReturnsCorrectProduct() {
            // Arrange
            int num1 = 7, num2 = 8;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(56));
        }

        [Test]
        public void DivisionTestReturnsCorrectQuotient()
        {
            // Arrange
            int num1 = 21, num2 = 3;

            // Act
            int? result = _calculator.Divide(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void DivisionBy0ReturnsNull()
        {
            // Arrange
            int num1 = 16, num2 = 0;

            // Act
            int? result = _calculator.Divide(num1, num2);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void AdditionWithNegativeNumbers()
        {
            // Arrange
            int num1 = -5, num2 = 3;

            // Act
            int result = _calculator.Add(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(-2));
        }

        [Test]
        public void MultiplicationWithNegativeNumbers()
        {
            // Arrange
            int num1 = -7, num2 = 8;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(-56));
        }

        [Test]
        public void MultiplicationByZero()
        {
            // Arrange
            int num1 = 10, num2 = 0;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }




    }
}