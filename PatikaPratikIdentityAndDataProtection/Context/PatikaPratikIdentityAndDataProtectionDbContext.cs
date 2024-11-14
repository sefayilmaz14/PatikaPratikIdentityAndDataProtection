using Microsoft.EntityFrameworkCore;
using PatikaPratikIdentityAndDataProtection.Entities;

namespace PatikaPratikIdentityAndDataProtection.Context
{
    public class PatikaPratikIdentityAndDataProtectionDbContext : DbContext
    {

        public PatikaPratikIdentityAndDataProtectionDbContext(DbContextOptions<PatikaPratikIdentityAndDataProtectionDbContext> options) : base(options)
        {

        }

        public DbSet<UserEntity> Users => Set<UserEntity>();
    }
}
