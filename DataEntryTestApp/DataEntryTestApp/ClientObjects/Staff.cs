using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryTestApp
{
    public class Staff
    {
        public string name { get; }
        public float pay { get; set; } // pounds per hour

        public bool used = false; // used for setting up event, prevents one staff member having multiple roles

        //constructor
        public Staff(string _name, float _pay)
        {
            name = _name;
            pay = _pay;
        }
    }
}
