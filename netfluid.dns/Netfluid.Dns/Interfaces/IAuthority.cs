namespace Netfluid.Dns.Interfaces
{
    public interface IAuthority
    {
        bool AreWeAuthority(string name);
    }
}
