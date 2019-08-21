namespace Firepuma.Api.Abstractions.Actor
{
    public interface IRemoteIpProviderHolder
    {
        IRemoteIpProvider Provider { get; set; }
    }
}