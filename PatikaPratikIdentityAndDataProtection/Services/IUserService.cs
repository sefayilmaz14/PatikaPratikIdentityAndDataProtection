using PatikaPratikIdentityAndDataProtection.Dtos;
using PatikaPratikIdentityAndDataProtection.Types;

namespace PatikaPratikIdentityAndDataProtection.Services
{
    public interface IUserService
    {

        Task<ServiceMessage> AddUser(AddUserDto user);
        
    }
}
