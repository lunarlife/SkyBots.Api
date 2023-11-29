namespace SkyBots.Api.Connection;

public struct Token
{
    private long _token;

    public Token(string value)
    {
        _token = Convert.ToInt64(value, 16);
    }

    public static implicit operator Token(string value) => new(value);
}