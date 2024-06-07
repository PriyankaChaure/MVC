using CustomeActionFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomeActionFilters.CustomFilters
{
   public class algofilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
            chaureEntities ch = new chaureEntities();
            actioninfo rec=new actioninfo();
            rec.ActionName = filterContext.ActionDescriptor.ActionName;
            rec.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            rec.LogDateTime=DateTime.Now;
            ch.actioninfoes.Add(rec);
            ch.SaveChangesAsync();

        }
    }
}