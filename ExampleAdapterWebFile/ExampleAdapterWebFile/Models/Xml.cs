using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class Xml {
        private string path;
        private string content;
        public string Path { get => path; set => path=value; }
        public string Content { get => content; set => content=value; }
        public Xml(string iPath) {
            Path=iPath;
            Content=File.ReadAllText(Path);
        }

        public Xml(string iPath,string iContent) {
            Path=iPath;
            Content=iContent;
        }

    }
}