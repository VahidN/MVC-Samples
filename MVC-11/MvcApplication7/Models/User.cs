using System;
using System.Web.Mvc;
using System.ComponentModel;
using MvcApplication7.Binders;

namespace MvcApplication7.Models
{
    //[Bind(Exclude = "IsAdmin")]
    //[ModelBinder(typeof(PersianDateModelBinder))]
    public class User
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public DateTime AddDate { set; get; }

        //[ReadOnly(true)]
        public bool IsAdmin { set; get; }
    }
}