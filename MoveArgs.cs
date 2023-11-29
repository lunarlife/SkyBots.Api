using SkyBotsApi.Math;

namespace SkyBotsApi;

public struct MoveArgs
{
    public MoveArgs()
    {
        Target = default;
        Sprint = false;
    }

    public Vector3<float> Target { get; init; }
    public bool Sprint { get; init; }
    public int MaxFallDistance { get; init; } = 3;
}