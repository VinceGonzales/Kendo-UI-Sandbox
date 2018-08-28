using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Xolartek.Web.Models
{
    public static class Utility
    {
        public static HtmlString StarsLabel(this HtmlHelper helper, int stars)
        {
            StringBuilder labelStr = new StringBuilder();
            for(int i=0;i<stars;i++)
            {
                labelStr.Append(@"<span class='k-icon k-i-star k-i-bookmark'></span>");
            }
            return new HtmlString(labelStr.ToString());
        }
    }
}