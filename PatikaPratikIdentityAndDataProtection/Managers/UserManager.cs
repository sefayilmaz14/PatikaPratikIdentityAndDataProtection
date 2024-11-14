using PatikaPratikIdentityAndDataProtection.Context;
using PatikaPratikIdentityAndDataProtection.Dtos;
using PatikaPratikIdentityAndDataProtection.Entities;
using PatikaPratikIdentityAndDataProtection.Services;
using PatikaPratikIdentityAndDataProtection.Types;

namespace PatikaPratikIdentityAndDataProtection.Managers
{
    public class UserManager : IUserService
    {
        private readonly PatikaPratikIdentityAndDataProtectionDbContext _context;

        public UserManager(PatikaPratikIdentityAndDataProtectionDbContext context)
        {
            _context = context;
        }
        public async Task<ServiceMessage> AddUser(AddUserDto user)
        {
            var userEntity = new UserEntity
            {
                Email = user.Email,
                Password = user.Password,
            };

            _context.Users.Add(userEntity);
            _context.SaveChanges();
            
            return new ServiceMessage 
            { IsSucceed = true };

        }
    }
}
