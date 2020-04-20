using JetBrains.Annotations;

namespace StinxRP.Communications.Server
{
    /// <summary>
    /// Represents a client connected to the server
    /// </summary>
    [PublicAPI]
    public interface IClient
    {
        /// <summary>
        /// Gets the server client handle.
        /// </summary>
        /// <value>
        /// The server client handle.
        /// </value>
        int Handle { get; }

        /// <summary>
        /// Gets the client name.
        /// </summary>
        /// <value>
        /// The client name.
        /// </value>
        string Name { get; }

        /// <summary>
        /// Gets the client end point.
        /// </summary>
        /// <value>
        /// The end point.
        /// </value>
        string EndPoint { get; }

        /// <summary>
        /// Gets the client Identifier Payload.
        /// </summary>
        /// <value>
        /// The client Identifier Payload.
        /// </value>
        string IdentifierPayload { get; }

        /// <summary>
        /// Gets the client ping.
        /// </summary>
        /// <value>
        /// The client ping.
        /// </value>
        int Ping { get; }
    }
}