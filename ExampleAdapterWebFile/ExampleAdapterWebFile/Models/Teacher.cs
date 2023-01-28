using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class Teacher : APerson {
        private string subject; 
        public string Subject { get => subject; set => subject=value; }
        public Teacher() {
        } 
        public override string SayHello() {
            return $"Xin chào, tôi là giáo viên. {ToString()}";
        }
    }
} 