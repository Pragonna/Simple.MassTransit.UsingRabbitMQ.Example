
namespace FakeDataCreator.Library.FakeEntities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public Customer(string firstName = null)
        {
            Id = Guid.NewGuid();
            Tickets = new HashSet<Ticket>();
            FirstName = firstName;
            LastName = $"{firstName} //lastName";
        }


    }
}
