using SkyBots.Api;
using SkyBots.Api.Connection;

namespace Example;

public class Program : SkyProgram
{
    public override Token Token => "TOKEN HERE";

    public override void Init(ConnectionResult result)
    {
        Console.WriteLine(result);
        if (result != ConnectionResult.Connected) return;
        var availableBots = Island.GetAvailableBots();
        if (availableBots.Length == 0) Console.WriteLine("No available bots.");
        Island.InitBot(new BotInitArgs
        {
            DisplayName = "Example",
            Id = availableBots.First()
        }).AddHook<MinerBotHook>().Activate();
    }
}