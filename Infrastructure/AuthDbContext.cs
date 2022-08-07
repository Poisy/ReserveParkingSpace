using System.Linq;
using Domain.Entities;
using Domain.Seeds;
using Infrastructure.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    /// <summary> IdentityDbContext which communicates directly with the Identity database. </summary>
    public class AuthDbContext : IdentityDbContext
    {
        //=============================================================================================
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
            
        }

        
        //=============================================================================================
        /// <summary> Seeds a IdentityUsers into the database. <br/>
        /// Comment this method to avoid it if you desire.</summary>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            var users = UserSeed.Generate();
            var identityUsers = IdentityUserSeed.Generate(users);

            builder.Entity<IdentityUser>().HasData(identityUsers);
        }
    }
}