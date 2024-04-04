using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    internal class PizzaDAL
    {

        private string _id;
        private string _name;
        private int _price;
        private string _topping;


        public PizzaDAL(string id, string name, int price, string topping)
        {
            _id = id;
            _name = name;
            _price = price;            
            _topping = topping;
        }
        
        public string Id { get { return _id; } }
        public string Name { get { return _name; } set {_name = value; } }
        public int Price { get { return _price; } set {_price = value;} }
        public string Topping { get { return _topping;} set {_topping = value;}  }
        

        public override string ToString()
        {
            return _id + " " + _name + ", " + _price + ", " + _topping;
        }

    }
}
