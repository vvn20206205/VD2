using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExampleAdapterWebFile.Models {
    class Student : APerson {
        private string score;
        private string id;
        public string Score { get => score; set => score=value; }
        public string Id { get => id; set => id=value; } 
        public Student() {
        } 
        public override string SayHello() {
            return $"Xin chào, tôi là sinh viên. {ToString()}";
        }
    } 
}