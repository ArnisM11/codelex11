using System;
namespace Exercise6
{
    class Dog
    {
        private string name;
        private string sex;
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
}
