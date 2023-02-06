using NUnit.Framework;

namespace Practic.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(10, 1) == 11);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(10, 1) == 9);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(10, 2) == 20);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(10, 2) == 5);
        }
    }
}