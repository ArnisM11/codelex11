using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your weight(kg) ---> ");
            int weightKg = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height(cm) ---> ");
            int heightCm = Convert.ToInt32(Console.ReadLine());

            float weightLbs = weightKg * 2.2046f;
            float heightIn = heightCm * 0.393700787f;

            Console.WriteLine("Your weight in pounds = " + weightLbs.ToString("N2"));
            Console.WriteLine("Your height in inches = " + heightIn.ToString("N2"));

            float bmi = weightLbs * 703 / (heightIn * heightIn);

            if (bmi < 18.5) Console.WriteLine("You classify as underweighted, because your BMI is " + bmi);
            else if (bmi > 25) Console.WriteLine("You classify as overweighted, because your BMI is " + bmi);
            else Console.WriteLine("You have an optimal weight, because your BMI is " + bmi);

            Console.ReadKey();

        }
    }
}