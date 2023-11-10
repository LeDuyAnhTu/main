using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BHX
{
    public class Discount
    {
        //Fields
        private string _ID, _Name;
        private LinkedList<Product> _Products;
        private LinkedList<Branch> _Branches;
        private string _discount_Amount;

        //Constructor
        public Discount(string iD, string name, LinkedList<Product> products, LinkedList<Branch> branches, string discount_Amount)
        {
            _ID = iD;
            _Name = name;
            _Products = products;
            _Branches = branches;
            _discount_Amount = discount_Amount;
        }

        //Properties
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public LinkedList<Product> Products { get => _Products; set => _Products = value; }
        public string Discount_Amount { get => _discount_Amount; set => _discount_Amount = value; }
        public LinkedList<Branch> Branches { get => _Branches; set => _Branches = value; }

        //Method
        public string toFile()
        {
            return _ID 
                + "#" + _Name 
                + "#" + Ultilities.getIDString(Products) 
                + "#" + Ultilities.getIDString(Branches) 
                + "#" + _discount_Amount;
        }
    }
}
