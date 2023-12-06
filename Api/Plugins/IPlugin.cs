namespace SkyBots.Api.Plugins;

public interface IPlugin
{
    public string PluginName { get; }
    public string PluginDescription { get; }
}