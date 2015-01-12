using System;
using System.Collections.Generic;

namespace MvcApplication17.Models
{
    public class Employee
    {
        public int Id { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime AddDate { get; set; }
        public double Salary { get; set; }
        public IList<Project> Projects { get; set; }
    }
}