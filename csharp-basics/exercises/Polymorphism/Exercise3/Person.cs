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
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string address { get; set; }
        private int id { get; set; }

        public Person()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            address = string.Empty;
            id = 0;
        }
        public Person(string firstName, string lastName, string address,int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.id = id;
        }
        public virtual void display()
        {
            var result = "\nFirst name : " + firstName + "\n";
            result += "Last name : " + lastName + "\n";
            result += "Address : " + address + "\n";
            result += "ID : " + id ;
            Console.WriteLine(result);
        }


    }
}
