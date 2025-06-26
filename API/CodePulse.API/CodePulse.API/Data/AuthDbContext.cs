using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "ec53d7ff-4725-46e6-85bf-836e8ac48b85";
            var writerRoleId = "e9f9b31d-1006-499b-88ac-160c886b2c4f";

            //Careate Reader and Writer Role
            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper(),
                    ConcurrencyStamp = readerRoleId
                },
                new IdentityRole()
                {
                    Id = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper(),
                    ConcurrencyStamp = writerRoleId
                }
            };
            //Seed the roles
            builder.Entity<IdentityRole>().HasData(roles);

            //Create an Admin User
            var adminUserId = "67bc2761-87f5-4a1b-96c6-bed4a256d69f";
            var admin = new IdentityUser()
            {
                Id = adminUserId,
                UserName = "admin@codepulse.com",
                Email = "admin@codepulse.com",
                NormalizedEmail = "admin@codepulse.com".ToUpper(),
                NormalizedUserName = "admin@codepulse.com".ToUpper(),
                PasswordHash = "AQAAAAIAAYagAAAAEJ83Ps13C/bCXQVIe1h7r+c0ptPCtNfarpFrqbJiVnjtA4EwkD1j1kRpxyAgbSF6EQ==",
                SecurityStamp = "static-sec-stamp-001", 
                ConcurrencyStamp = "static-conc-stamp-001" 
            };
           
            
            builder.Entity<IdentityUser>().HasData(admin);
            //Give Roles to Admin
            var adminRoles = new List<IdentityUserRole<string>>()
            {
                new()
                {
                    UserId = adminUserId,
                    RoleId = readerRoleId
                },
                new()
                {
                    UserId = adminUserId,
                    RoleId = writerRoleId
                },
            };
            builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);

        }

    }
}
