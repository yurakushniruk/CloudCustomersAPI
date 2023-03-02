using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User
                {
                        Id = 1,
                        Name = "Test User 1",
                        Email = "testuser1@example.com",
                        Address = new Address()
                        {
                            Street="123 Main str.",
                            City = "Madison",
                            ZipCode = "33701"
                        }
                },
                new User
                {
                        Id = 2,
                        Name = "Test User 2",
                        Email = "testuser2@example.com",
                        Address = new Address()
                        {
                            Street="900 Market str.",
                            City = "Somewhere",
                            ZipCode = "53704"
                        }
                },
            };
    }
}
