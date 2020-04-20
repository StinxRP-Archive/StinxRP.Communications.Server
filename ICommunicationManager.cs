using JetBrains.Annotations;

namespace StinxRP.Communications.Server
{
    [PublicAPI]
    public interface ICommunicationManager
    {
        ICommunicationTarget Event(string @event);
    }
}