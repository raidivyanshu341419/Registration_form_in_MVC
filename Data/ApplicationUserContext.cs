using Microsoft.EntityFrameworkCore;
using Registration_form.Models;

namespace Registration_form.Data
{
    public class ApplicationUserContext : DbContext
    {
        public ApplicationUserContext(DbContextOptions<ApplicationUserContext> options): base(options)
        {

        }
        public DbSet<User> UserRegistration { get; set; }
    }
}
