using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Student : Person
    {
        private double _gpa { get; set; }
        public Student(double gpa)
        {
            this._gpa = gpa;
        }
        public Student(string firstName, string lastName, string address, int id,double gpa) : base(firstName, lastName, address, id)
        {
            this._gpa = gpa;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("GPA : " + _gpa);
        }
    }
}
