using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class Json {
        #region Fields 
        private string path;
        private string content;
        #endregion
        #region Properties 
        public string Content { get => content; set => content=value; }
        public string Path { get => path; set => path=value; }
        #endregion
        #region Constructor 
        public Json(string iPath) {
            Path=iPath;
            Content=File.ReadAllText(iPath);
        }
        public Json(string iPath,string iContent) {
            Path=iPath;
            Content=iContent;
        }
        #endregion
    }
}