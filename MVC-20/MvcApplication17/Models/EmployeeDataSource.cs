using System;
using System.Collections.Generic;

namespace MvcApplication17.Models
{
    public static class EmployeeDataSource
    {
        public static IList<Employee> CreateEmployees()
        {
            var list = new List<Employee>();
            var rnd = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                list.Add(new Employee
                    {
                        Id = i + 1000,
                        FirstName = "fName " + i,
                        LastName = "lName " + i,
                        AddDate = DateTime.Now.AddYears(-rnd.Next(1, 10)),
                        Salary = rnd.Next(400, 3000),
                        Projects = CreateRandomProjects()
                    });
            }
            return list;
        }

        private static IList<Project> CreateRandomProjects()
        {
            var list = new List<Project>();
            var rnd = new Random();
            for (int i = 0; i < rnd.Next(1, 7); i++)
            {
                list.Add(new Project
                {
                    Id = i,
                    Name = "Project " + i
                });
            }
            return list;
        }
    }
}