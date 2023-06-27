using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SimpleBlazorApp.Data
{
    public class AccountDbContext : IdentityDbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {

        }
    }
}
