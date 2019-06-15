namespace Firepuma.Api.Abstractions.Actor
{
    public interface IActorProviderHolder<TActor> where TActor : IActorIdentity
    {
        IActorProvider<TActor> Provider { get; set; }
    }
}
