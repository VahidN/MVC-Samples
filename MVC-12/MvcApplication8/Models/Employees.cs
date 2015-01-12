using System;
using System.Collections.Generic;

namespace MvcApplication8.Models
{
    public class Employees
    {
        public IList<Employee> CreateEmployees()
        {
            return new[]
            {
                new Employee { Id = 1, AddDate = DateTime.Now.AddYears(-3), Name = "Emp-01", Salary = 3000},
                new Employee { Id = 2, AddDate = DateTime.Now.AddYears(-2), Name = "Emp-02", Salary = 2000},
                new Employee { Id = 3, AddDate = DateTime.Now.AddYears(-1), Name = "Emp-03", Salary = 1000}
            };
        }
    }
}