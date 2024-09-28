
namespace FakeDataCreator.Library.FakeEntities
{
    public class SomeEvent
    {
        public Guid Id{ get; set; }
        public string EventName{ get; set; }
        public DateTime EventDate{ get; set; }
        public DateTime CreatedDate{ get; set; }
        public int EventCapacity{ get; set; }
        public SomeEvent(string eventName = null, DateTime eventDate = default)
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            EventName = eventName;
            EventDate = eventDate;
        }
    }
}
