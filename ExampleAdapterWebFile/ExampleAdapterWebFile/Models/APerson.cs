using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    abstract class APerson {
        private string name;
        public string Name { get => name; set => name=value; }
        public APerson() {
        }
        // html title
        public abstract string  ToString();
    }
}