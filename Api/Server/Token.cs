namespace SkyBots.Api.Server;

public struct Token
{
    public static Token Invalid => new(long.MinValue);
    private readonly long _token;

    public Token(string value)
    {
        try
        {
            _token = string.IsNullOrEmpty(value) ? default : Convert.ToInt64(value, 16);
        }
        catch (Exception)
        {
            _token = Invalid._token;
        }
    }

    public Token(long value)
    {
        _token = value;
    }

    public static implicit operator Token(string value) => new(value);

    public static bool operator ==(Token left, Token right) => left._token == right._token;

    public static bool operator !=(Token left, Token right) => !(left == right);
    public bool Equals(Token other) => _token == other._token;

    public override bool Equals(object? obj) => obj is Token other && Equals(other);

    public override int GetHashCode() => _token.GetHashCode();
}