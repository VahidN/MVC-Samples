using System.Collections.Generic;

namespace MvcApplication18.Models
{
    public static class EmployeeDataSource
    {
        public static IList<Employee> CreateEmployees()
        {
            var list = new List<Employee>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(new Employee { Id = i + 1, Name = "name " + i });
            }
            return list;
        }
    }
}