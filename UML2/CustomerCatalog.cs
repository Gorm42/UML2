using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    //Step 3.
    internal class CustomerCatalog
    {
        List<CustomerDAL> customerList = new List<CustomerDAL>();

        //Step 3-2. - Create New Customer (ADD customer)
        public void AddCustomer(CustomerDAL customer)
        {
            customerList.Add(customer);
        }

        //Step 3-2. - Read Customer (Print)
        public void PrintCustomerList()
        {
            foreach (CustomerDAL customer in customerList)
            {
                Console.WriteLine(customer);
            }
        }


        //Step 3-2. -  Update Customer (RETURN customer) 
        public void UpdateCustomer(string id, string name, string address, string city, int zipCode, int phoneNumber, string email)
        {
            try
            {
                foreach (CustomerDAL customer in customerList)
                {
                    if (customer.Name == id)
                    {
                        customer.Name = name;
                        customer.Address = address;
                        customer.City = city;
                        customer.ZipCode = zipCode;
                        customer.PhoneNumber = phoneNumber;
                        customer.Email = email;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("The ID most likely didn't exist or you typed it with letters rather than numbers."); }
        }

        //Step 3-2. - Delete Customer (REMOVE)
        public void DeleteCustomer(CustomerDAL customer)
        {
            //if (customer.Id == id)
            customerList.Remove(customer);
        }


        //Step 3-2-1. - Read Customer (READ)
        public List<CustomerDAL> ReadCustomerList()
        {
            return customerList;
        }




    }
}
