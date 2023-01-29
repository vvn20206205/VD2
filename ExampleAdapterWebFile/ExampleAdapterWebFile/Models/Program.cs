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
                    Xml _XmlSupport = new Xml(iFilePath);
                    IAnalyticsLibrary _DemoDibrary = new DemoThirdPartyAnalyticsLibrary();
                    return _DemoDibrary.ProcessData<Student>(_XmlSupport,new Student());
                } else if(_FileInfo.Extension==CONFIG.FILE_JSON_EXTENSION) {
                    //(không hỗ trợ)
                    Json _JsonNoSupport = new Json(iFilePath);
                    JsonToXmlAdapter _AdapterJsonToXml = new JsonToXmlAdapter(_JsonNoSupport);

                    IAnalyticsLibrary _DemoDibrary = new DemoThirdPartyAnalyticsLibrary();
                    return _DemoDibrary.ProcessData<Teacher>(_AdapterJsonToXml.GetData(),new Teacher());
                } else {
                    throw new PathIncorrect();
                }
            } catch(Exception ex) {
                return HtmlStringException.ConvertExceptionMessageToHtmlString(ex);
            }
        }
    }

}//Và tệ hơn nữa, bạn có thể không có quyền truy cập vào mã nguồn của thư viện ngay từ đầu, khiến cho phương pháp này không thể thực hiện được.