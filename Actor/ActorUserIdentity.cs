namespace Firepuma.Api.Abstractions.Actor
{
    public class ActorUserIdentity
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }

        public ActorUserIdentity(string id, string email, string fullName)
        {
            Id = id;
            Email = email;
            FullName = fullName;
        }
    }
}
