using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BHX
{
    /// <summary>
    /// Loại sản phẩm
    /// </summary>
    internal class Product_Type
    {
        //Field
        private string _ID, _Name;
        private string _Description;

        //Contructor
        public Product_Type(string iD, string name, string description)
        {
            _ID = iD;
            _Name = name;
            _Description = description;
        }

        //Properties
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Description { get => _Description; set => _Description = value; }

        //Method
        public string toFile()
        {
            return _ID + "#" + _Name + "#" + _Description;
        }
    }
}
