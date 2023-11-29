using SkyBotsApi.Math;

namespace SkyBotsApi.Plugins;

public interface IMoveBotPlugin
{
    public Vector3<double> Position { get; }
    public Task Move(MoveArgs args, out CancelToken token);
    public Task Move(Vector3<double> offset);
}