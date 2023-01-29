using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class Teacher : APerson {
        #region Fields 
        private string subject;
        #endregion
        #region Properties 
        public string Subject { get => subject; set => subject=value; }
        #endregion
        #region Constructor 
        public Teacher() {
        }
        #endregion
        #region Methods 
        // html title
        public override string ToString() {
            return "Teacher";
        }
        #endregion
    }
}