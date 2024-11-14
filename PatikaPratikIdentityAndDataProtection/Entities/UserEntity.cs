using System.ComponentModel.DataAnnotations;

namespace PatikaPratikIdentityAndDataProtection.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }


    }
}
