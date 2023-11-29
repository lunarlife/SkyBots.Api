namespace SkyBots.Api;

public interface IPluginManager
{
    public void LoadPlugin(string path);
    public string PluginDirectory { get; }
}