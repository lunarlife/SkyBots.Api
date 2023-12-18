using SkyBots.Api.Core.Internal;

namespace SkyBots.Api.Core;

public static class Time
{
    public static float DeltaTime => SkyBotsBase.Implementation.ProgramLoop.DeltaTime;
    public static float FixedDeltaTime => SkyBotsBase.Implementation.ProgramLoop.FixedDeltaTime;

    public static int TargetTickRate
    {
        get => SkyBotsBase.Implementation.ProgramLoop.TargetTickRate;
        set => SkyBotsBase.Implementation.ProgramLoop.TargetTickRate = value;
    }

    public static float TotalTime => SkyBotsBase.Implementation.ProgramLoop.TotalTime;

    public static int TargetFixedTickRate
    {
        get => SkyBotsBase.Implementation.ProgramLoop.TargetFixedTickRate;
        set => SkyBotsBase.Implementation.ProgramLoop.TargetFixedTickRate = value;
    }
}