using ExampleAdapterWebFile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleAdapterWebFile.Controllers {
    public class ExampleController : Controller {
        public ActionResult ProcessExample(string type) {
            try {
                ViewBag.Title=CONFIG.NAME;

                string _FilePath;
                if(type==CONFIG.XML_CHOOSE) {
                    _FilePath=Server.MapPath(CONFIG.FILE_PATHS_XML);
                } else if(type==CONFIG.JSON_CHOOSE) {
                    _FilePath=Server.MapPath(CONFIG.FILE_PATHS_JSON);
                } else {
                   throw new UnDeveloped();
                } 
                ViewData["ResultHtmlString"]=Program.Main(_FilePath);
                return View();
            } catch(Exception ex) {
                ViewData["ResultHtmlString"]=HtmlStringException.ConvertExceptionMessageToHtmlString(ex);
                return View();
            }
        }
    }
}