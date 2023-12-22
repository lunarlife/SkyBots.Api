namespace SkyBots.Api.Jobs.Instructions;

public interface IInstruction
{
    public bool IsReady();
    public void Reset();
}