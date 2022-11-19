using System.Web.Mvc;

namespace OyunHaberleri.Models
{
    public static class HtmlHelperExtentions
    {
        public static MvcHtmlString btn_outline_danger(this HtmlHelper html, string text)
        {
            string btn_danger = string.Format($@"<button style='display: inline - block; border: 1px solid #dc3545; background-color: white; color: #dc3545'>{text}</button>");
            return MvcHtmlString.Create(btn_danger);
        }
    }

}