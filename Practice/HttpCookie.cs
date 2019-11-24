using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Practice
{ 
    partial class Program
    {
        public class HttpCookie
        {
            private readonly Dictionary<string, string> _dictionary;  // generic class with generic parameters (key with type string and value string), with the name _dictionary

            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }
            
            public string this[string key] // index syntax
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
        }
    }
}

