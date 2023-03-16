using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise3
{
    internal class Person
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private string _address { get; set; }
        private int _id { get; set; }

        public Person()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _address = string.Empty;
            _id = 0;
        }
        public Person(string firstName, string lastName, string address,int id)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._address = address;
            this._id = id;
        }
        public virtual void display()
        {
            var result = "\nFirst name : " + _firstName + "\n";
            result += "Last name : " + _lastName + "\n";
            result += "Address : " + _address + "\n";
            result += "ID : " + _id ;
            Console.WriteLine(result);
        }


    }
}
