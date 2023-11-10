using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BHX
{
    public class City
    {
        // Fields
        private string _ID, _Name;

        // Constructor
        public City(string iD, string name)
        {
            ID = iD;
            Name = name;
        }

        // Properties
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }

        //Method
        public string toFile()
        {
            return ID + "#" + Name;
        }
    }
}
