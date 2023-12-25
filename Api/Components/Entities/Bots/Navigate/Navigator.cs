
using SkyBots.Api.Mathematics;

namespace SkyBots.Api.Components.Entities.Bots.Navigate;

public abstract class Navigator : Component
{
    public abstract INavigateTask Navigate(Vector3<float> target, bool sprint);
}