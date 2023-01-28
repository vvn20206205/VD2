using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    public class HtmlStringException {
        public static HtmlString ConvertExceptionMessageToHtmlString(Exception iEx) {
            return new HtmlString($"\r\n<div class=\"alert alert-danger\">\r\n<h1>{iEx.Message.Replace(".",".<br>")}</h1>\r\n</div>");
        }
    }
}
