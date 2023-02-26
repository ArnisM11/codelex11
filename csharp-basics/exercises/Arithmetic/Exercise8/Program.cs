namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            float salary1 = 7.5f;
            float salary2 = 8.20f;
            float salary3 = 10.0f;

            int hours1 = 35;
            int hours2 = 47;
            int hours3 = 73;

            Console.WriteLine("Employee1 hours worked : " + hours1 + " and recieved : " + CalculateSalary(salary1, hours1));
            Console.WriteLine("Employee2 hours worked : " + hours2 + " and recieved : $" + CalculateSalary(salary2, hours2));
            Console.WriteLine("Employee3 hours worked : " + hours3 + " and recieved : $" + CalculateSalary(salary3, hours3));

            Console.ReadKey();

        }

        static string CalculateSalary(float salary,int hours)
        {
            if (salary < 8.0) return "error";
            if (hours <= 40) return (hours * salary).ToString("N2");
            float salaryAbove = 40 * salary;
            salaryAbove += (salary * 1.5f) * (hours - 40.0f);
            return salaryAbove.ToString("N2");

        }
    }
}