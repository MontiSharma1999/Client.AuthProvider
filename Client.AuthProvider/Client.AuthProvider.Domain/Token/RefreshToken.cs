namespace Client.AuthProvider.Domain.Token;
public class RefreshToken
{
    public string Token { get; private set; }
    public DateTime Expires { get; private set; }
    public DateTime Created { get; private set; }

    public RefreshToken(string token, DateTime expires, DateTime created)
    {
        Token = token;
        Expires = expires;
        Created = created;
    }
}
