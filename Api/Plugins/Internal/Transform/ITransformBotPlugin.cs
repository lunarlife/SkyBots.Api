using SkyBots.Api.Math;

namespace SkyBots.Api.Plugins.Internal.Transform;

public interface ITransformBotPlugin : IBotPlugin
{
    public Vector3<float> Position { get; }
    public IMoveTask Move(MoveArgs args, out CancelToken token);
}