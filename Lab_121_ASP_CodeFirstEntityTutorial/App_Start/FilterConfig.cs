using System.Web;
using System.Web.Mvc;

namespace Lab_121_ASP_CodeFirstEntityTutorial
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
