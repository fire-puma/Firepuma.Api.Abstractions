using System.Threading.Tasks;

namespace Firepuma.Api.Abstractions.Actor
{
    public interface IActorProvider<TActor>
    {
        Task<TActor> GetActor();
    }
}
