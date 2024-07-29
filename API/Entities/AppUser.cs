using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        //[Required]  add migration for database validation or else remove
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastActive { get; set;} = DateTime.UtcNow;
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interesrts { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Photo> photos { get; set; } = new();

        // public int getAge() 
        // { 
        //     return DateOfBirth.CalculateAge(); 
        // }
    }
}