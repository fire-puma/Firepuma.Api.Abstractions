using System.Threading.Tasks;

namespace Firepuma.Api.Abstractions.Actor
{
    public interface IActorProvider<TActor> where TActor : IAuditActor
    {
        Task<TActor> GetActor();
    }
}
