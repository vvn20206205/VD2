using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    /// <summary>
    /// Custom Exception 
    /// </summary>
    class UnDeveloped : Exception {
        public UnDeveloped()
        : base("Đường dẫn này chưa phát triển.Vui lòng kiểm tra lại.") { }
    }
    class PathIncorrect : Exception {
        public PathIncorrect()
        : base("Đường dẫn file App_Data\\MyData không đúng.Vui lòng kiểm tra lại.") { }
    }
}