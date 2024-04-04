using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{    
    internal class CustomerDAL
    {
        //instance fields
        private string _id;
        private string _name;
        private string _address;
        private string _city;
        private int _zipCode;
        private int _phoneNumber;
        private string _email;
        
        //Constructor
        public CustomerDAL (string id, string name, string address, string city, int zipCode, int phoneNumber, string email) 
        {
            _id = id;
            _name = name;
            _address = address;
            _city = city;
            _zipCode = zipCode;
            _phoneNumber = phoneNumber;
            _email = email;
        }

        //property - get return for constructor values.
        public string Id { get { return _id; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public int ZipCode { get { return _zipCode; } set { _zipCode = value; } }
        public int PhoneNumber { get { return _phoneNumber;} set { _phoneNumber = value; } }
        public string Email { get { return _email;} set { _email = value; } }
        

        //ToString Metode
        public override string ToString()
        {
            return _name + ", " + _address + ", " + _city + ", " + _zipCode + ", " + _phoneNumber + ", " + _email;
        }

        

    }
}
