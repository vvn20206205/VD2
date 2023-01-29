using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml;
using System.Xml.Linq;

namespace ExampleAdapterWebFile.Models {
    class LibraryDemo : IAnalyticsLibrary {
        public HtmlString ProcessData<T>(Xml iObjectXml,T iObject) {
            string _XmlString = iObjectXml.Content;
            XDocument _XDoc = XDocument.Parse(_XmlString);
            List<string> ListTakePropertiesObject = TakePropertiesObject<T>(iObject);
            ListTakePropertiesObject.Reverse();

            string _OutputTable = OutputTable<T>(iObject,ListTakePropertiesObject,_XDoc);

            return new HtmlString(_OutputTable);
        }
        private static List<string> TakePropertiesObject<T>(T iObject) {
            List<string> _Properties = new List<string>();
            PropertyInfo[] _PropInfos = iObject.GetType().GetProperties();
            foreach(PropertyInfo itemPropInfo in _PropInfos) {
                _Properties.Add(itemPropInfo.Name);
            }
            return _Properties;
        }
        private string OutputTable<T>(T iObject,List<string> iListTakePropertiesObject,XDocument iXDoc) {
            string _OutputTable = ""+
            "<div class=\"alert alert-success\">\r\n"+
            "<h1>"+iObject.ToString().Split('.')[2]+"</h1>\r\n"+
            "</div>"+
            "<div style=\"border: 1px blue solid;\" class=\"container mt-5\"> "+
            "<table id=\"example\" class=\"display\" style=\"width:100%\">";
            string _THead = HeadTable(iListTakePropertiesObject);
            string _TBody = BodyTable<T>(iObject,iListTakePropertiesObject,iXDoc);

            _OutputTable+=$"{_THead} {_TBody} ";
            _OutputTable+=" "+
            "</table> "+
            "</div> ";
            return _OutputTable;
        }
        private string HeadTable(List<string> iListTakePropertiesObject) {
            string _THead = " <thead> <tr> ";
            foreach(string itemListTakePropertiesObject in iListTakePropertiesObject) {
                _THead+=$"<th>{itemListTakePropertiesObject}</th> ";
            }
            _THead+=" </tr> </thead>";
            return _THead;
        }
        private string BodyTable<T>(T iObject,List<string> iListTakePropertiesObject,XDocument iXDoc) {
            var _XmlElements = iXDoc.Root.Elements(iObject.GetType().Name.ToLower());
            string _TBody = " <tbody> ";

            foreach(var itemXmlElements in _XmlElements) {
                _TBody+=" <tr> ";
                foreach(string itemListTakePropertiesObject in iListTakePropertiesObject) {
                    _TBody+=$"<td>{itemXmlElements.Element(itemListTakePropertiesObject.ToLower()).Value}</td> ";
                }
                _TBody+=" </tr> ";
            }
            _TBody+=" </tbody> ";
            return _TBody;
        }
    }
}