using FakeDataCreator.Library.FakeEntities;

namespace Message.Shared.Messages
{
    public interface ISomeMessage
    {
        object Data{ get; set; }
    }
}