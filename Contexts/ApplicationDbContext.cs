using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace User.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }
        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
            (
                new IdentityRole { Name = "Admin", NormalizedName = "Admin" },
                new IdentityRole { Name = "User", NormalizedName = "User" },
                new IdentityRole { Name = "Rea", NormalizedName = "Rea" },
                new IdentityRole { Name = "Her", NormalizedName = "Her" }
            );
        }
    }
}