﻿using System.Web;
using System.Web.Mvc;
using AppfailReporting.Mvc;

namespace MvcApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AppfailReportAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}