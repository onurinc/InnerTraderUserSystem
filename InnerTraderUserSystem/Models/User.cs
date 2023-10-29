namespace InnerTraderUserSystem.Models
{
    public class User
    {

        public Guid IdentityId { get; set; } = Guid.NewGuid();

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

    }
}
