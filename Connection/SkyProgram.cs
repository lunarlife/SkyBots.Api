namespace SkyBotsApi.Connection;

public abstract class SkyProgram
{
    public abstract Token Token { get; }
    public IIsland Island { get; }
    public abstract void Init(ConnectionResult result);
}