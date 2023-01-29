using Newtonsoft.Json;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class JsonToXmlAdapter : IAnalyticsLibrary {
        #region Fields 
        private Json jsonlData;
        #endregion
        #region Properties 
        internal Json JsonlData { get => jsonlData; set => jsonlData=value; }
        #endregion
        #region Constructor 
        public JsonToXmlAdapter(Json iJsonData) {
            JsonlData=iJsonData;
        }
        #endregion
        #region Methods 
        public Xml GetData() {
            // Quá trình chuyển đổi có sử dụng thêm thư viện using Newtonsoft.Json; 
            string _iJsonString = JsonlData.Content;
            var _XmlObject = JsonConvert.DeserializeXmlNode(_iJsonString);
            string _JsonToXml = _XmlObject.OuterXml;
            return new Xml("",_JsonToXml);
        }
        public HtmlString ProcessData<T>(Xml iObjectXml,T iObject) {
            return new HtmlString("Không bắt buộc code vì kế thừa từ IAnalyticsLibrary theo lí thuyết Adapter");
        }
        #endregion
    }
}