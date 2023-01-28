using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml.Linq;

namespace ExampleAdapterWebFile.Models {
    class DemoThirdPartyAnalyticsLibrary : IAnalyticsLibrary {
        private static List<string> LayPropertiesObject<T>(T iObjectXml) {
            List<string> properties = new List<string>();
            PropertyInfo[] propInfos = iObjectXml.GetType().GetProperties();
            foreach(PropertyInfo propInfo in propInfos) {
                properties.Add(propInfo.Name);
            }
            return properties;
        }

        public HtmlString ProcessData<T>(Xml  iObjectXml,string iXmlObjectRootNode,T iObject) {
            string xmlString = iObjectXml.Content;
            XDocument xdoc = XDocument.Parse(xmlString);
            var XML_Elements = xdoc.Root.Elements(iXmlObjectRootNode);
            List<string> CacLayPropertiesObject = LayPropertiesObject<T>(iObject);
            CacLayPropertiesObject.Reverse();
            string _KetQuaOutPutBang = ""+
            "<div style=\"border: 1px blue solid;\" class=\"container mt-5\"> "+
            "<table id=\"example\" class=\"display\" style=\"width:100%\">";
            string daubangthead = " "+
            "<thead> "+
            "<tr> ";
            string thanbangtbody = " <tbody> ";
            foreach(string str in CacLayPropertiesObject) {
                daubangthead+=$"<th>{str}</th> ";
            }
            foreach(var element in XML_Elements) {
                thanbangtbody+=" <tr> ";
                foreach(string str in CacLayPropertiesObject) {
                    thanbangtbody+=$"<td>{element.Element(str.ToLower()).Value}</td> ";
                }
                thanbangtbody+=" </tr> ";
            }
            daubangthead+=""+
            "</tr> "+
            "</thead>";
            thanbangtbody+=" </tbody> ";
            _KetQuaOutPutBang+=$"{daubangthead} {thanbangtbody} ";
            _KetQuaOutPutBang+=" </table> </div> ";
            return new HtmlString(_KetQuaOutPutBang);
        }
    }
}