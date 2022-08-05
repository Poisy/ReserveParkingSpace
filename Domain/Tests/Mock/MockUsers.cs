using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Tests.Mock
{
    public class MockUsers
    {
        public static User CurrentUser { get; set; }

        public MockUsers()
        {
            CurrentUser = new User
            {
                Id = Guid.NewGuid(),
                Username = "MainUser",
                FirstName = "MainUserFirstName",
                LastName = "MainUserLastName"
            };
        }
        
        public List<User> GetUsers()
        {
            var users = new List<User>();

            for (int i = 0; i < 50; i++)
            {
                users.Add(new User
                {
                    Id = Guid.NewGuid(),
                    Username = $"User{i}",
                    FirstName = $"Fname{i}",
                    LastName = $"Lname{i}"
                });
            }

            return users;
        }
    }
}