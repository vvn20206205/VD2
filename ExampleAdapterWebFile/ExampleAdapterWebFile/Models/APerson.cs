using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    abstract class APerson {
        #region Fields 
        private string name;
        #endregion
        #region Properties 
        public string Name { get => name; set => name=value; }
        #endregion
        #region Constructor 
        public APerson() {
        }
        #endregion
        #region Methods 
        // html title
        public abstract string  ToString();
        #endregion 
    }
}