using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MvcApplication9.CustomValidators;

namespace MvcApplication9.Models
{
    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {
        class CustomerMetadata
        {

        }
    }

    public partial class Customer : IValidatableObject
    {
        //[System.Web.Mvc.Compare]        

        public int Id { set; get; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50)]
        [System.Web.Mvc.Remote(action: "CheckUserNameAndEmail",
                               controller: "Customer",
                               AdditionalFields = "Email",
                               HttpMethod = "POST",
                               ErrorMessage = "Username is not available.")]
        public string Name { set; get; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required.")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
                           ErrorMessage = "Please enter a valid email address.")]
        public string Email { set; get; }

        [Range(0, 10)]
        [Required(ErrorMessage = "Rating is required.")]
        public double Rating { set; get; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required.")]
        [MyDateValidator(MinYear = 2000,
                         ErrorMessage = "Please enter a valid date.")]
        public DateTime StartDate { set; get; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var fields = new[] { "StartDate" };
            if (StartDate > DateTime.Now || StartDate < new DateTime(2000, 1, 1))
                yield return new ValidationResult("Please enter a valid date.", fields);

            if (Rating > 4 && StartDate < new DateTime(2003, 1, 1))
                yield return new ValidationResult("Accepted date should be greater than 2003", fields);
        }
    }
}