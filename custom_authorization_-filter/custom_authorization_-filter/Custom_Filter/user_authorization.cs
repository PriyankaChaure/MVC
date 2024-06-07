using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace custom_authorization__filter.Custom_Filter
{
    public class user_authorization:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            // base.OnAuthorization(filterContext);
            if (filterContext.HttpContext.Session["userid"]==null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { action="SignIn",Controller="ManageUsers"}));
            }
        }
    }
}