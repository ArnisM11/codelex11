using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Employee : Person
    {
        private string jobTitle { get; set; }

        public Employee(string jobTitle) 
        {
            this.jobTitle = jobTitle;
        }
        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            this.jobTitle = jobTitle;
        }
        public override void display()
        {
            base.display();
            Console.WriteLine("Job title : " + jobTitle);
        }
    }
}
