namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }

        //[Required]  add migration for database validation or else remove
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}