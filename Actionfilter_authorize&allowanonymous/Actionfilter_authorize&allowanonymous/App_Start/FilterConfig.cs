using System.Web;
using System.Web.Mvc;

namespace Actionfilter_authorize_allowanonymous
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
