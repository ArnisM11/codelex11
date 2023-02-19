namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] classes = { "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II", "AP US History", "Business Computer Information Systems" };
            string[] teachers = { "Ms.Lapan", "Mrs.Gideon", "Mr.Davis", "Ms.Palmer", "Ms.Garcia", "Mrs.Barnett", "Ms.Johannessen", "Mr.James" };
            Console.WriteLine("+----------------------------------------------------------------+");
            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine("| " + (i + 1) + " | " + classes[i].PadRight(40) + " | " + teachers[i].PadRight(15) + " | ");   //PadRight(40), lai ietilptu pedejaa no lekcijaam, ar 26 vietaam bija par maz
            }
            Console.WriteLine("+----------------------------------------------------------------+");
            Console.ReadKey();
        }
    }
}