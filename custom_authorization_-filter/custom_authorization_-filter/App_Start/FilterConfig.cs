﻿using System.Web;
using System.Web.Mvc;

namespace custom_authorization__filter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
