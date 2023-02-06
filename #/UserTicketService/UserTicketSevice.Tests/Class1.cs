using NUnit.Framework;

namespace UserTicketService.Tests
{
    public class Calculator
    {
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }

    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.True(50 == 50);
            var calculator = new Calculator();
            //Assert.That(calculator.Subtraction(300, 10) == 290);

        }
    }
}