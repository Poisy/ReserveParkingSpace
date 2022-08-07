using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Seeds
{
    /// <summary> Class for generating <see cref="User"/> objects. </summary>
    public class UserSeed
    {
        /// <summary> Basic Id which every generated user starts with. </summary>
        public static string GeneralId => "4c33537b-e856-463b-811e-e8e0597501";
        
        /// <summary> Generates <see cref="User"/> objects. </summary>
        /// <param name="count">The number of generated users.</param>
        /// <returns><see cref="IEnumerable{T}"/> which contains the users.</returns>
        public static IEnumerable<User> Generate(int count = 50)
        {
            var users = new List<User>();

            for (int i = 0; i < count; i++)
            {
                users.Add(new User
                {
                    Id = new Guid(i > 9 ? GeneralId+i : GeneralId+"0"+i),
                    Username = $"User{i}",
                    FirstName = $"Fname{i}",
                    LastName = $"Lname{i}",
                    Departure = i % 3 == 0 ? "IT" : "Economy"
                });
            }

            return users;
        }
    }
}