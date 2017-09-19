using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Canary.Common.Helpers
{
    public class ViewHelper : IViewHelper
    {
        private const string DefaultLayoutFileName = "_Layout.cshtml";
        public string GetLayoutPath(string layoutFileName = null)
        {
            if (!string.IsNullOrWhiteSpace(layoutFileName))
            {
                return string.Format("~/Views/{0}", layoutFileName);
            }
            return string.Format("~/Views/{0}", DefaultLayoutFileName);
        }
    }
}