using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Account
    {
        private string name; // instance variable -- default value = null

        // method that sets the account name in the object
        public void SetName(string accountName)
        {
            name = accountName; // store the account name
        }

        // method that retrieves the account name from the object
        public string GetName()
        {
            return name; // returns name's value to this method's caller
        }
    }
}
