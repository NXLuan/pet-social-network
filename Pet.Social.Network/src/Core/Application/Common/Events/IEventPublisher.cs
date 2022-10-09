using Pet.Social.Network.Shared.Events;

namespace Pet.Social.Network.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}