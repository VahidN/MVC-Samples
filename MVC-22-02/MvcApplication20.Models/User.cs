using System.ComponentModel.DataAnnotations;

namespace MvcApplication20.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public int Id { set; get; }

        [Display(ResourceType = typeof(MvcApplication20.Resources.Home_Index_cshtml),
                 Name = "Name")]
        public string Name { set; get; }
    }
}
