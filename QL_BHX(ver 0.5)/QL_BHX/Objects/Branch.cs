using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BHX
{
    public class Branch
    {
        //Fields
        private string _ID;
        private string _Name;
        private string _Address;
        private City _City;

        public Branch(string iD, string name, string address, City city)
        {
            _ID = iD;
            _Name = name;
            _Address = address;
            _City = city;
        }

        //Properties
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Address { get => _Address; set => _Address = value; }
        internal City City { get => _City; set => _City = value; }

        //Method
        public string toFile()
        {
            return ID + "#" + Name + "#" + Address + "#" + City.ID;
        }

    }
}
