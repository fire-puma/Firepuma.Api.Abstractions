namespace Firepuma.Api.Abstractions.Actor
{
    public interface IAuditActor
    {
        string Id { get; set; }
        string AuditName { get; set; }
    }
}