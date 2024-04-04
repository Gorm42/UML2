using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    internal class Menu
    {
        //Step 1-2.
        List<PizzaDAL> pizzaList = new List<PizzaDAL>(); //instance field / attributes / call object.
        
        //Add pizza to list (CREATE) Step 1-2.
        public void AddPizza(PizzaDAL pizza)
        {
            pizzaList.Add(pizza);            
        }

        //Delete pizza (DELETE) Step 1-2.
        public void DeletePizza(PizzaDAL pizza)
        {
            pizzaList.Remove(pizza);
        }

        //Update Pizza (UPDATE) Step 1-2.
        public void UpdatePizza(string id, string name, int price, string topping)
        {
            foreach (PizzaDAL pizza in pizzaList) 
            {
                if (pizza.Id == id)
                {
                    pizza.Name = name;
                    pizza.Price = price;
                    pizza.Topping = topping;
                }                    
            }
        }

        //Read pizza (READ) Step 1-2.
        public List<PizzaDAL> ReadPizza()
        {
            return pizzaList;
        }

        //Step 1-2-1. Print Menu.
        public void PrintMenu() 
        {
            foreach (PizzaDAL pizza in pizzaList) 
            {
                Console.WriteLine(pizza);
            }
        }

        //Step 1-2-2. Search for user-query.
        public PizzaDAL? SearchPizza(string query) 
        {
            foreach (PizzaDAL pizza in pizzaList)
            {
                if (pizza.Name == query)
                {
                    return pizza;
                }
            }
            //throw new Exception("Dummy - can't you spell?");
            return null;
        }
        
        //STEP 2        MENU CHOICE      MENU CHOICE     MENUC CHOICE
        public int MenuChoice () //Step 2 Dialog. Gonna be hella long.
        {
            PrintMenu();
            Console.WriteLine("Would you like to; \n 1: add a new pizza to the menu, \n 2: Delete a pizza? \n 3: Update a pizza? \n 4: Search for a pizza? \n 5: Display the pizza menu? \n 6 Do nothing. \n Please press 1-6.");
            string answer1 = Console.ReadLine();

           //Exception handling
           try 
           { 


            //Add a pizza
            if (answer1 == "1")             //Add a pizza
            {
                Console.WriteLine("Please write the pizza's menu number.");
                string answerId = Console.ReadLine();
                Console.WriteLine("Please write the pizza's name.");
                string answerName = Console.ReadLine();
                Console.WriteLine("Please write the pizza's price.");
                int answerPrice = Convert.ToInt32(Console.ReadLine());  //exception handling - what if wrong number/type.
                Console.WriteLine("Please write the pizza's topping(s).");
                string answerTopping = Console.ReadLine();

                PizzaDAL userPizza = new PizzaDAL(answerId, answerName, answerPrice, answerTopping);
                //Ved +1 tilføjelse skal der udtænkes en metode til give objekterne et unikt navn.
                //Foreach increment?
                AddPizza(userPizza);

                 return 1;

            }

            //Delete a pizza
            else if (answer1 == "2")        //Delete a pizza
            {
                Console.WriteLine("Which pizza would you like to delete? Please type 0-∞");
                try 
                {
                int deletePizzaAnswer = Convert.ToInt32(Console.ReadLine());
                pizzaList.RemoveAt(deletePizzaAnswer);
                }
                catch (Exception ex) {Console.WriteLine("You probably didn't have a pizza to delete, did you?");}
                return 2;

            }

            //Update a pizza
            else if (answer1 == "3")        //Update a pizza
            {
                Console.WriteLine("Please write the pizza's menu number.");    //different variable names from add pizza?
                string answerId = Console.ReadLine();
                Console.WriteLine("Please write the pizza's name.");
                string answerName = Console.ReadLine();
                Console.WriteLine("Please write the pizza's price.");
                int answerPrice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please write the pizza's topping(s).");
                string answerTopping = Console.ReadLine();

                UpdatePizza(answerId, answerName, answerPrice, answerTopping);

                return 3;

            }

            //Search for a pizza
            else if (answer1 == "4")         //Search for a pizza
            {
                Console.WriteLine("Please write the name of the pizza you are searching for, with the first letter capitalized.");
                string userQuery = Console.ReadLine();
                SearchPizza(userQuery);     

                return 4;      
            }
            
            //Display the pizza menu
            else if (answer1 == "5")        //Display the pizza menu
            {
                PrintMenu();

                return 5;
            }
            
            
            else if (answer1 == "6") 
            {
                Console.WriteLine("Thank you for doing nothing! You have eased the burden of this program significantly. We hope your continued apathy will serve you greatly. Thank you for running UML2.");
                // Make this into finally-exception Console.WriteLine("*Loss of sanity, mental-wellbeing and acuity is not the responsibility of UML2 or Zealand Ervhervsakademi.");
                return 6;
            }
            else
            {
                Console.WriteLine("That wasn't 1-6.");
                

                return 7;
            }
           }
            catch (Exception ex) { Console.WriteLine("Something went wrong, ya!"); return 40; }
            finally { Console.WriteLine("Loss of sanity, mental-wellbeing and acuity is not the responsibility of UML2 or Zealand Ervhervsakademi."); }
            
        }
    }
}




    







