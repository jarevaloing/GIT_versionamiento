﻿using System.Web;
using System.Web.Mvc;

namespace GIT_versionamiento
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
