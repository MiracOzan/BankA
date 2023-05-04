using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class BDbContext : IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MIRAÇ;initial catalog=BankA;integrated Security = true;TrustServerCertificate=True");
        }

        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
       
    }
}
