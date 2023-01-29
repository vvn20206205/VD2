using ExampleAdapterWebFile.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace ExampleAdapterWebFile.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Title=CONFIG.GROUP_NAME;
            return View();
        }
    }
}
