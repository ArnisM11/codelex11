namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John","Liepin","Brivibas 11", 15);
            Student s1 = new Student("Dohn", "Siepin", "Trivibas 11", 17, 45.00);
            Employee e1 = new Employee("Doe", "Tree", "Kalna 15", 16, "Mezcirtejs");
            p1.display();
            s1.display();
            e1.display();

            Console.ReadKey();
        }
    }
}