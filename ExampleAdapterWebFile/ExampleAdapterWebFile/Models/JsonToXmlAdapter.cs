using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml.Linq;

namespace ExampleAdapterWebFile.Models {
    class JsonToXmlAdapter : IAnalyticsLibrary {
        private Json _jsonlData;
        public JsonToXmlAdapter(Json iJsonData) {
            _jsonlData=iJsonData;
        }
        public Xml GetData() {
            string iJsonString = _jsonlData.Content;
            var xmlObject = JsonConvert.DeserializeXmlNode(iJsonString);
            string jsonToXml = xmlObject.OuterXml;
            return new Xml("",jsonToXml);
        }
        public HtmlString ProcessData<T>(Xml iObjectXml,string iXmlObjectRootNode,T iObject) {

            return new HtmlString("Không cần bắt buộc code vì kế thừa từ interface IAnalyticsLibrary");
        }
    }
}