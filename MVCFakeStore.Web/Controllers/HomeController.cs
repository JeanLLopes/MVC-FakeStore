using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFakeStore.Web.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route]
        [Route("Index")]
        public ViewResult Index()
        {
            return View();
        }
    }
}