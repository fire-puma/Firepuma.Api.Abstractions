using System.Threading.Tasks;

namespace Firepuma.Api.Abstractions.Actor
{
    public interface IActorProvider
    {
        Task<ActorUserIdentity> GetActor();
    }
}
