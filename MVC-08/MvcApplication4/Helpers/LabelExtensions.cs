using System.Web.Mvc;
using System.Web.UI;
using System.IO;

namespace MvcApplication4.Helpers
{
    public static class LabelExtensions
    {
        public static MvcHtmlString MyLabel(this HtmlHelper helper, string target, string text)
        {
            return MvcHtmlString.Create(string.Format("<label for='{0}'>{1}</label>", target, text));
        }

        public static MvcHtmlString MyNewLabel(this HtmlHelper helper, string target, string text)
        {
            var labelTag = new TagBuilder("label");
            labelTag.MergeAttribute("for", target);
            labelTag.InnerHtml = text;
            return MvcHtmlString.Create(labelTag.ToString());
        }

        public static MvcHtmlString MyCustomLabel(this HtmlHelper helper, string target, string text)
        {
            var writer = new HtmlTextWriter(new StringWriter());
            writer.RenderBeginTag(HtmlTextWriterTag.Label);
            writer.AddAttribute(HtmlTextWriterAttribute.For, target);
            writer.Write(text);
            writer.RenderEndTag();
            return MvcHtmlString.Create(writer.InnerWriter.ToString());
        }
    }
}