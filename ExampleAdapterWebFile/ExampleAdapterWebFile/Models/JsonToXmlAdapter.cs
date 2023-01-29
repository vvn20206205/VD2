using Newtonsoft.Json; 
using System.Web; 

namespace ExampleAdapterWebFile.Models {
    class JsonToXmlAdapter : IAnalyticsLibrary {
        private Json _jsonlData;
        public JsonToXmlAdapter(Json iJsonData) {
            _jsonlData=iJsonData;
        }
        public Xml GetData() {
            // Quá trình chuyển đổi có sử dụng thêm thư viện using Newtonsoft.Json; 
            string iJsonString = _jsonlData.Content;
            var xmlObject = JsonConvert.DeserializeXmlNode(iJsonString);
            string jsonToXml = xmlObject.OuterXml;
            return new Xml("",jsonToXml);
        }
        public HtmlString ProcessData<T>(Xml iObjectXml, T iObject) { 
            return new HtmlString("Không bắt buộc code vì kế thừa từ IAnalyticsLibrary theo lí thuyết Adapter");
        }
    }
}