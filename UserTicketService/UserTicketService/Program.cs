namespace UserTicketService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Calculator
    {
        public int Add(int one, int two)
        {
            return one + two;
        }
    }

    public class Ticket
    {
        public int Id { get; }
        public string Description { get; }
        public int Price { get; }

        public Ticket(int id, string description, int price)
        {
            this.Id = id;
            this.Description = description;
            this.Price = price;
        }
    }

    public interface ITicketService
    {
        int GetTicketPrice(int ticketId);
    }

    public class TicketService : ITicketService
    {
        public int GetTicketPrice(int ticketId)
        {
            var ticket = FakeBaseData.FirstOrDefault(t => t.Id == ticketId);
            return (ticket is null) ?
               throw new TicketNotFoundException() : ticket.Id;
        }

        public Ticket GetTicket(int ticketId)
        {
            return new Ticket(1, "", 1);
        }

        private IEnumerable<Ticket> FakeBaseData
        {
            get
            {
                return new List<Ticket>
         {
            new Ticket(1, "Москва - Санкт-Петербург", 3500),
            new Ticket(2, "Челябинск - Магадан", 3500),
            new Ticket(3, "Норильск - Уфа", 3500)
         };
            }
        }

    }

    public class TicketNotFoundException : Exception
    {
    }

    public class TicketPrice
    {
        ITicketService ticketService;
        public TicketPrice(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        public int MakeTicketPrice(int ticketId)
        {
            return ticketService.GetTicketPrice(ticketId);
        }
    }
}