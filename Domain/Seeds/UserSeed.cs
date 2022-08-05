using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Seeds
{
    public class UserSeed
    {
        public static string GeneralId => "4c33537b-e856-463b-811e-e8e0597501";
        
        public static IEnumerable<User> Generate()
        {
            var users = new List<User>();

            for (int i = 0; i < 50; i++)
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