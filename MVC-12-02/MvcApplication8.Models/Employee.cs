using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcApplication8.Models
{
    public class Employee
    {
        //[ScaffoldColumn(false)]

        [HiddenInput(DisplayValue=false)]
        public int Id { set; get; }

        [DisplayFormat(NullDisplayText = "-")]
        public string Name { set; get; }

        [DisplayName("Annual Salary ($)")]
        [DisplayFormat(DataFormatString  = "{0:n}", ApplyFormatInEditMode = true)]
        public decimal Salary { set; get; }

        public string Address { set; get; }

        [DisplayName("Gender")]
        [UIHint("GenderOptions")]
        public bool IsMale { set; get; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime AddDate { set; get; }        
    }
}