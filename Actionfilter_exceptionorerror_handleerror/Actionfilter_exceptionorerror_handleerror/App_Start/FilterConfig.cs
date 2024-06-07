using System.Web;
using System.Web.Mvc;

namespace Actionfilter_exceptionorerror_handleerror
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
