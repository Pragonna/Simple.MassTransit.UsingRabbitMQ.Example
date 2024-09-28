
using FakeDataCreator.Library.FakeEntities;

namespace FakeDataCreator.Library
{
    public class SomeDataCreator
    {
        public static IEnumerable<Ticket> CreateTickets()
        {
            IEnumerable<Customer> customers = new List<Customer>()
            {
                new("customer1"),
                new("customer2"),
                new("customer3"),
                new("customer4"),
                new("customer5"),
            };

            SomeEvent someEvent = new("SomeEvent", DateTime.Now.AddDays(20));
            List<Ticket> tickets = new List<Ticket>();

            foreach (var customer in customers)
            {
                tickets.Add(new(someEvent.Id, customer.Id, true, someEvent.EventDate));
            }

            return tickets;
        }
    }
}





