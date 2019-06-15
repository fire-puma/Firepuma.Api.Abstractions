namespace Firepuma.Api.Abstractions.Actor
{
    public interface IActorIdentity
    {
        string Id { get; }
        string Email { get; }
        string FullName { get; }
    }
}