
namespace FakeDataCreator.Library.FakeEntities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid? SomeEventId { get; set; }
        public Guid? CustomerId { get; set; }
        public bool TicketStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public SomeEvent? SomeEvent { get; set; }
        public Customer? Customer { get; set; }

        public Ticket(Guid? someEventId = null, Guid? customerId = null, bool ticketStatus = false, DateTime expirationDate = default)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow;
            SomeEventId = someEventId;
            CustomerId = customerId;
            TicketStatus = ticketStatus;
            ExpirationDate = expirationDate;
        }
    }
}
