using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Langcademy.Web.HttpModules
{
    public class CultureModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginReuest;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        private void Context_BeginReuest(object sender, EventArgs e)
        {
            var urlParts = HttpContext.Current.Request.Url.AbsoluteUri.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (urlParts.Count() > 2)
            {
                string lang = urlParts[2];

                if (lang == "bg")
                {
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("bg");
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg");
                }
            }
        }

    }
}