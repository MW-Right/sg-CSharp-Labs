﻿using System.Web;
using System.Web.Mvc;

namespace Lab_121_ASP_CodeFirstEntity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
