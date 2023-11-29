namespace SkyBotsApi;

public interface IPluginManager
{
    public void LoadPlugin(string path);
    public string PluginDirectory { get; }
}