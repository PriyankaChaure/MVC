using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Attribute_Routing_Ex.Controllers
{
    [RoutePrefix("priyanka")]
    public class TestController : Controller
    {

        [Route("tomandjerry/in")]
        [Route("doreamon/ind")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("pr/{str}/say")]
        [Route("pr/say/{str}")]
        public string sayhello(string str)
        {
            return "value of string is:" + str;
        }
        [Route("te/by/{id:int:min(10):max(50)}")]
        public string saybye(string id)
        {
            return "value of id:" + id;
        }
    }
}