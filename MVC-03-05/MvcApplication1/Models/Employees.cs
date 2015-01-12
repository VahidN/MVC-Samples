using System.Collections.Generic;

namespace MvcApplication1.Models
{
    public class Employees 
    {
        public IList<Employee> CreateEmployees()
        {
            return new[]
                {
                    new Employee { Email = "name1@site.com", FirstName = "name1", LastName = "LastName1" },
                    new Employee { Email = "name2@site.com", FirstName = "name2", LastName = "LastName2" },
                    new Employee { Email = "name3@site.com", FirstName = "name3", LastName = "LastName3" }
                };
        }
    }
}