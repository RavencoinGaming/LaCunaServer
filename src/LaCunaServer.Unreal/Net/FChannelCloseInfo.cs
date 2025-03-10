﻿using LaCunaServer.Unreal.Net.Channels;

namespace LaCunaServer.Unreal.Net;

public readonly struct FChannelCloseInfo
{
    public FChannelCloseInfo(uint id, EChannelCloseReason closeReason)
    {
        Id = id;
        CloseReason = closeReason;
    }

    public uint Id { get; }
    public EChannelCloseReason CloseReason { get; }
}