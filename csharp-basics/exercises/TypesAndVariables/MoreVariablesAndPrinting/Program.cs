using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Eyes, Teeth, Hair;
            int Age, Height, Weight;

            Name = "Zed A. Shaw";
            Age = 35;
            Height = 74;  // inches
            Weight = 180; // lbs
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + Height + " inches tall. Which is " + inchesToCm(Height) + " in centimeters.");
            Console.WriteLine("He's " + Weight + " pounds heavy. Which is " + lbsToKg(Weight).ToString("N2") + " in kilos. ");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + Height + ", and " + Weight
                               + " I get " + (Age + Height + Weight) + ".");

            Console.ReadKey();
        }
        public static float inchesToCm(int i)
        {
            return i * 2.54f;
        }
        public static float lbsToKg(int l)
        {
            return l * 0.453592f;
        }
    }
}