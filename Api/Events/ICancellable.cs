namespace SkyBots.Api.Events;

public interface ICancellable
{
    public bool IsCancelled { get; set; }
}