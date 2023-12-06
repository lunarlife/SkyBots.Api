using SkyBots.Api;
using SkyBots.Api.Connection;
using SkyBots.Api.Math;
using SkyBots.Api.Plugins.Internal.Transform;

namespace Example;

public class Program : SkyProgram
{
    public override Token Token => "TOKEN HERE";

    public override async void Init(AuthResult result)
    {
        Console.WriteLine(result);
        if (result != AuthResult.Successfully) return;
        var availableBots = Island.GetAvailableBots();
        if (availableBots.Length == 0) Console.WriteLine("No available bots.");
        var bot = new TestBot();
        var botBindingResult = await bot.Bind(new BotInitArgs
        {
            DisplayName = "Example",
            Id = availableBots.First()
        });
        Console.WriteLine(botBindingResult);
        var plugin = bot.GetPlugin<ITransformBotPlugin>();
        var task = plugin.Move(new MoveArgs
        {
            Sprint = false,
            Target = new Vector3<float>(10f,10f)
        }, out var cancelToken);
    }
}