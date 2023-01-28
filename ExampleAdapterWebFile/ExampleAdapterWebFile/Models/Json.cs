using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class Json {
        private string path;
        private string content;

        public string Content { get => content; set => content=value; }
        public string Path { get => path; set => path=value; }
        public Json(string iPath) {
            Path=iPath;
            Content=File.ReadAllText(iPath);
        }

        public Json(string iPath,string iContent) {
            Path=iPath;
            Content=iContent;
        }
    }
}