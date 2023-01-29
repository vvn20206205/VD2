using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class Student : APerson {
        #region Fields 
        private string score;
        private string id;
        #endregion
        #region Properties 
        public string Score { get => score; set => score=value; }
        public string Id { get => id; set => id=value; }
        #endregion
        #region Constructor 
        public Student() {
        }
        #endregion
        #region Methods 
        // html title
        public override string ToString() {
            return "Student";
        }
        #endregion
    }
}