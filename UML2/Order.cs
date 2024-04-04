using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    internal class Order
    {
        private static int _orderIdCounter = 0;         //Order Count
        PizzaDAL _pizza;                                //instance field/variable with datatype PizzaDAL (the class PizzaDAL)
        CustomerDAL _customer;                          //instance field/variable with datatype customer
         


        //Constructor
        public Order(int orderIdCounter, PizzaDAL pizza, CustomerDAL customer)
        {
            _orderIdCounter = orderIdCounter;
            orderIdCounter++;
            _pizza = pizza;
            _customer = customer;
        }

        //property get-set for orderIdCounter
        private static int OrderId { get { return _orderIdCounter; } }

        //property for CustomerDAL
        public CustomerDAL Customer { get { return _customer; } }

        //method for calculatetotalprice:
        public double CalculateTotalPrice()
        {
            double totalPrice = (_pizza.Price * 1.25) + 40;
            return totalPrice;
        }
        //method for OrderPizzaName
        public string OrderPizzaName()
        {
            string pizzaName = _pizza.Name;
            return pizzaName;
        }

        //ToString Order
        public override string ToString()
        {
            return _pizza + ", " + _customer + ", " + _orderIdCounter;
        }


    }
}
