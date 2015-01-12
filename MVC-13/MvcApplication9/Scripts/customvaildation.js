/// <reference path="jquery-1.5.1-vsdoc.js" />
/// <reference path="jquery.validate-vsdoc.js" />
/// <reference path="jquery.validate.unobtrusive.js" />

jQuery.validator.addMethod("mydatevalidator",
 function (value, element, param) {
     debugger;
     return Date.parse(value) < new Date();
 });

jQuery.validator.unobtrusive.adapters.addBool("mydatevalidator");