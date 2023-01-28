using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace ExampleAdapterWebFile.Models {
    public class Program {
        public static HtmlString Main(string iFilePath) {
            try {
                FileInfo _FileInfo = new FileInfo(iFilePath);

                if(_FileInfo.Extension==CONFIG.FILE_XML_EXTENSION) {
                    //(có hỗ trợ)
                    Xml nghia = new Xml(iFilePath);
                    IAnalyticsLibrary library = new DemoThirdPartyAnalyticsLibrary();
                    return library.ProcessData<Student>(nghia,"student",new Student());
                } else if(_FileInfo.Extension==CONFIG.FILE_JSON_EXTENSION) {
                    //(không hỗ trợ)
                    Json nghia = new Json(iFilePath);
                    JsonToXmlAdapter adapter = new JsonToXmlAdapter(nghia);

                    IAnalyticsLibrary library = new DemoThirdPartyAnalyticsLibrary();
                    return library.ProcessData<Teacher>(adapter.GetData(),"teacher",new Teacher());
                } else {
                    throw new PathIncorrect();
                }
            } catch(Exception ex) {
                return HtmlStringException.ConvertExceptionMessageToHtmlString(ex);
            }
        }
    }

}