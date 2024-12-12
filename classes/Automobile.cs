using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpLearning.classes
{
    public class Automobile
    {
        private string _address; // field : always has underscore and small letter 
        public Automobile(string address) 
        {
            Console.WriteLine("I Run First");
            _address = address;
        }

        // public string Address { get; set; } // property : always has first letter capital
        // above property can be written as  to perform any data manipulation and operations.
        public string Address
        {
            get { return _address; } // get => _address;
            set { _address = value; } // set => _address = value;
        }
        
    }
}