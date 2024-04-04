using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    internal class ControllerStore
    {

        
        //Step 1 implemented test
        public static void StepOneDashThree() 
        {
            Menu menu = new Menu();
            PizzaDAL pizza00 = new PizzaDAL("01.", "Margherita", 69, "Tomato & cheese.");
            PizzaDAL pizza01 = new PizzaDAL("02.", "Vesuvio", 75, "Tomato, cheese & ham.");
            PizzaDAL pizza02 = new PizzaDAL("03.", "Cappriciosa", 80, "Tomato, cheese, ham & mushrooms.");
            menu.AddPizza(pizza00);
            menu.AddPizza(pizza01); 
            menu.AddPizza(pizza02);
            menu.PrintMenu();
            menu.DeletePizza(pizza02);
            menu.PrintMenu();
            menu.AddPizza(pizza02);
            menu.PrintMenu();
                           
            PizzaDAL? searchForPizza = menu.SearchPizza("Margherita");
            Console.WriteLine(searchForPizza);
            menu.UpdatePizza("01.", "NyPizza", 100000, "KØD."); //returnerer ikke noget, så intet at assigne.
            List<PizzaDAL> itIsLate = menu.ReadPizza();
            Console.WriteLine(itIsLate);
            menu.PrintMenu();

        }
        public static void StepTwoDashTwo() 
        {
            Menu menu = new Menu();
        
            for (int i = 0; i < 6; i++)
            {
                int x = menu.MenuChoice();
                Console.WriteLine("You pressed " + x);
            }
        }





        //List<CustomerDAL> customerList = new List<CustomerDAL>();
        //CustomerDAL customer1 = new CustomerDAL("Anders Jensen", "Øltorvet 3", "Roskilde", 4000, 33445566, "AndersJensen@gmail.com");
        //CustomerDAL customer2 = new CustomerDAL("Jens Andersen", "Maglegårdvej 3", "Roskilde", 4000, 11223344, "Jens.Andersen@gmail.com");
        //CustomerDAL customer3 = new CustomerDAL("Christian Frederiksen", "Hansensgade 4", "Roskilde", 4000, 55667788, "Christian.Frederiksen@gmail.com");

        /*public static CustomerDAL CreateCustomerList(CustomerDAL customer)
        {
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
        }*/



        //Order order1 = new Order(pizza00, customer1);
        //Order order2 = new Order(pizza01, customer2);
        //Order order3 = new Order(pizza02, customer3);


    }
}
