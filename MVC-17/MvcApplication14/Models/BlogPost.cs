using System;
using System.Web.Mvc;

namespace MvcApplication14.Models
{
    public class BlogPost
    {
        public int Id { set; get; }
        public DateTime AddDate { set; get; }
        public string Title { set; get; }

        [AllowHtml]
        public string Html { set; get; }
    }
}