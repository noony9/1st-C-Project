using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Account // lesson: auto-implemented properties; constructor
    {
        public string Name { get; set; }
        public Account(string accountName)
        {
            Name = accountName;
        }
        /*private string name; // instance variable

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; // remember that value is a keyword only in a property's context
            }
                 
        }*/
    }
}
