using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Helper
{
    public static class CategoryHelper
    {
        public static HtmlString DisplayCategoryName(this HtmlHelper htmlHelper, string Category)
        {
            var className = "";
            var CategoryName = "";

            if (Category == "0")
    {
                className = "success";
                CategoryName = "支出";
            }
            else
            {
                className = "danger";
                CategoryName = "收入";
              
            }
            return new MvcHtmlString($"<span class='text-{className}'>{CategoryName}</span>");
        }
    }
}