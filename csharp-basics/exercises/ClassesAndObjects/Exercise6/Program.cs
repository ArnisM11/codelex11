using System.Globalization;

namespace Exercise6
{
    class Dog
    {
        public string name;
        public string sex;
        public Dog? mother { get; set; }
        public Dog? father { get; set; }

        public Dog(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public string Name
        {
            get { return name; }
        }

        public string Sex
        {
            get { return sex; }
        }

        public string FathersName()
        {
            if (father == null) return "Unknown";
            else return father.Name;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return this.mother == otherDog.mother;
        }

    }
    class DogTest
    {
        static void Main()
        {
            Dog dog1 = new Dog("Max", "male");
            Dog dog2 = new Dog("Rocky", "male");
            Dog dog3 = new Dog("Sparky", "male");
            Dog dog4 = new Dog("Buster", "male");
            Dog dog5 = new Dog("Sam", "male");
            Dog dog6 = new Dog("Lady", "female");
            Dog dog7 = new Dog("Molly", "female");
            Dog dog8 = new Dog("Coco", "female");

            dog1.mother = dog6;
            dog1.father = dog2;
            dog8.mother = dog7;
            dog8.father = dog4;
            dog2.mother = dog7;
            dog2.father = dog5;
            dog4.mother = dog6;
            dog4.father = dog3;

            Console.WriteLine(dog8.FathersName());
            Console.WriteLine(dog3.FathersName());
            Console.WriteLine(dog8.HasSameMotherAs(dog2.mother));
            Console.ReadKey();
        }
    }
}