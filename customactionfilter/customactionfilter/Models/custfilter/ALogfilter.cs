using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace customactionfilter.Models.custfilter
{
    public class ALogfilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            customactionfilterEntities a=new customactionfilterEntities();
            alogTbl rec=new alogTbl();
            rec.LogDateTime = DateTime.Now;
            rec.ActionName = filterContext.ActionDescriptor.ActionName;
            rec.ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            a.alogTbls.Add(rec);
            a.SaveChanges();

        }
        
    }
}