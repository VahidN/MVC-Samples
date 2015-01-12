using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace MvcApplication9.CustomValidators
{
    public class MyDateValidator : ValidationAttribute, IClientValidatable
    {
        public int MinYear { set; get; }

        public override bool IsValid(object value)
        {
            if (value == null) return false;

            var date = (DateTime)value;
            if (date > DateTime.Now || date < new DateTime(MinYear, 1, 1))
                return false;

            return true;
        }

        /*protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var info = validationContext.ObjectType.GetProperty("Rating");
            //...
            return ValidationResult.Success;
        }*/

        #region IClientValidatable Members

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
                    ModelMetadata metadata, 
                    ControllerContext context)
        {
            var rule = new ModelClientValidationRule
            {
                ValidationType = "mydatevalidator",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName())
            };
            yield return rule;
        }

        #endregion
    }
}