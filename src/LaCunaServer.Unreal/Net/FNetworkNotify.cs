using LaCunaServer.Unreal.Net.Channels;
using LaCunaServer.Unreal.Net.Packets.Bunch;
using LaCunaServer.Unreal.Net.Packets.Control;

namespace LaCunaServer.Unreal.Net;

public interface FNetworkNotify
{
    EAcceptConnection NotifyAcceptingConnection();
    
    /// <summary>
    ///     Notification that a new connection has been created/established as a result of a
    ///     remote request, previously approved by NotifyAcceptingConnection
    /// </summary>
    void NotifyAcceptedConnection(UNetConnection connection);
    
    /// <summary>
    ///     Notification that a new channel is being created/opened as a result of a remote request (Actor creation, etc)
    /// </summary>
    bool NotifyAcceptingChannel(UChannel channel);

    /// <summary>
    ///     Handler for messages sent through a remote connection's control channel not required to handle the message,
    ///     but if it reads any data from Bunch, it MUST read the ENTIRE data stream for that message
    ///
    ///     (i.e. use FNetControlMessage::Receive())
    /// </summary>
    void NotifyControlMessage(UNetConnection connection, NMT messageType, FInBunch bunch);
}