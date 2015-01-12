using System.ComponentModel.DataAnnotations;

namespace MvcApplication19.Models
{
    public class Employee
    {
        [ScaffoldColumn(false)]
        public int Id { set; get; }
                
        [Display(ResourceType = typeof(MvcApplication19.Views.Home.Index_cshtml),
                 Name = "Name")]
        [Required(ErrorMessageResourceType = typeof(MvcApplication19.Views.Home.Index_cshtml),
                  ErrorMessageResourceName = "NameIsNotRight")]
        public string Name { set; get; }
    }
}