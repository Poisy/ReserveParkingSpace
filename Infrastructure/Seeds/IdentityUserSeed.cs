using System.Collections.Generic;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Seeds
{
    /// <summary> Class for generating <see cref="IdentityUser"/> objects. </summary>
    public class IdentityUserSeed
    {
        //=============================================================================================
        /// <summary> Generates <see cref="IdentityUser"/> objects. </summary>
        /// <param name="users">Users who needs to be transformed into IdentityUsers.</param>
        /// <returns><see cref="IEnumerable{T}"/> which contains the users.</returns>
        public static IEnumerable<IdentityUser> Generate(IEnumerable<User> users)
        {
            var identityUsers = new List<IdentityUser>();
            var hasher = new PasswordHasher<IdentityUser>();

            foreach (var user in users)
            {
                identityUsers.Add(new IdentityUser
                {
                    Id = user.Id.ToString(),
                    UserName = user.Username,
                    NormalizedUserName = user.Username.ToUpper(),
                    PasswordHash = hasher.HashPassword(null, user.Username+"!@#")
                });   
            }

            return identityUsers;
        }
    }
}