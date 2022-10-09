using Pet.Social.Network.Shared.Events;

namespace Pet.Social.Network.Domain.Common.Contracts;

public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}