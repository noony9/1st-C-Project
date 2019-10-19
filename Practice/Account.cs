using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Account
    {
        private string name; // instance variable

        //method that sets the acount ame in the object
        public void SetName(string accountName)
        {
            name = accountName;
        }
        public string GetName()
        {
            return name;
        }
    }
}
