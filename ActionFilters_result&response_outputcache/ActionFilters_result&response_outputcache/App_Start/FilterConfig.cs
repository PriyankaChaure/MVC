using System.Web;
using System.Web.Mvc;

namespace ActionFilters_result_response_outputcache
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
