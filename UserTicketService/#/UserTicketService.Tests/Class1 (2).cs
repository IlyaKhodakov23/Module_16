using Moq;
using NUnit.Framework;
using UserTicketService;

namespace UserTicketServise.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test1()
        {
            Assert.True(100 == 100);
        }
    }

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
    }

    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GeTicketPriceMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GeTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

        [TestFixture]
        public class TicketPriceTests
        {
            [Test]
            public void TicketPriceMustReturnNotNullableTicket()
            {
                var mockTicketService = new Mock<ITicketService>();
                mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
                mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
                mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);

                var ticketPriceTest = new TicketPrice(mockTicketService.Object);
                Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
            }
        }

        [Test]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicket(1));
        }

    }
}