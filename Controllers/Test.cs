using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Controllers
{
    //public class TestController
    [Controller]
    public class Test : Controller
    {
        public ActionResult Index()
        {
            return Content("Hello From test index");
        }

        public String About()
        {
            return "Hello from test About";
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
