using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_primitive_type.Controllers
{
    public class PrimitiveController : Controller
    {
        // GET: Primitive
        public string sayhello(string id)
        {
            return "say hello method called!!!"+id;
        }
        public string saybye(int id = 5)
        {
            return "value of id is:"+id;
        }
        public string foo(string id, string str)
        {
            return "value of id is:"+id+"value of str is:"+str;
        }
        public string dodivision(int a, int b)
        {
            return "division is:"+(a/b);
        }
    }
}