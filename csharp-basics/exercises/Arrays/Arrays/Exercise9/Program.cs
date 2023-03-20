namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = new string[] { "Mavis", "senaida", "letty" };
            string[] str2 = new string[] { "samuel", "MABELLE", "letitia", "meridith" };
            string[] str3 = new string[] { "Slyvia", "Kristal", "Sharilyn", "Calista" };
            CapMe(str1);
            CapMe(str2);
            CapMe(str3);
            Console.ReadKey();
        }

        static void CapMe(string[] names)
        {
            for (int i =0;i<names.Length;i++)
            {
                names[i] = names[i].ToLower();
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1);
            }
            for(int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.WriteLine();
        }
    }
}