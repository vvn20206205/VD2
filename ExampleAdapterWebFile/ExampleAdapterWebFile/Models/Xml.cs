using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class Xml {
        #region Fields 
        private string path;
        private string content;
        #endregion
        #region Properties 
        public string Path { get => path; set => path=value; }
        public string Content { get => content; set => content=value; }
        #endregion
        #region Constructor 
        public Xml(string iPath) {
            Path=iPath;
            Content=File.ReadAllText(Path);
        }
        public Xml(string iPath,string iContent) {
            Path=iPath;
            Content=iContent;
        }
        #endregion
    }
}