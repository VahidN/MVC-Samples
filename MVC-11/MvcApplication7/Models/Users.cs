using System;
using System.Collections.Generic;

namespace MvcApplication7.Models
{
    public class Users
    {
        public IList<User> CreateInMemoryDataSource()
        {
            return new[]
            {
                new User { Id = 1, Name = "User1", Password = "123", IsAdmin = false, AddDate = DateTime.Now },
                new User { Id = 2, Name = "User2", Password = "456", IsAdmin = false, AddDate = DateTime.Now },
                new User { Id = 3, Name = "User3", Password = "789", IsAdmin = true, AddDate = DateTime.Now }
            };
        }
    }
}