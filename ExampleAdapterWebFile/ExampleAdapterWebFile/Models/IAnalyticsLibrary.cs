using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    interface IAnalyticsLibrary {
        HtmlString ProcessData<T>(Xml  iObjectXml,string iXmlObjectRootNode,T iObject);
    }
}
