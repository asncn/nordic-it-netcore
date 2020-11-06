using System;
class Program
{
    class Person
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                foreach (char _char in value)
                {
                    if (!char.IsLetter(_char))
                    {
                        throw new Exception(message: "Error! You have to use only letters! Try again:");
                    }
                }
                _name = value;
            }
        }
        private byte _age;
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
              if (value > 0 && value < 99)
                _age = value;
            }
        }
        public string Description
        {
            get { return $"Name: {Name}, age in 4 years: {Age + 4}."; }
        }
    }
    static void Main(string[] args)
    {
        Person[] persons = new Person[3];
        persons[0] = new Person();
        persons[1] = new Person();
        persons[2] = new Person();

        Console.Write("Enter name 0: ");
        persons[0].Name = Console.ReadLine();

        Console.Write("Enter age 0: ");
        persons[0].Age = byte.Parse(Console.ReadLine());

        Console.Write("Enter name 1: ");
        persons[1].Name = Console.ReadLine();
        Console.Write("Enter age 1: ");
        persons[1].Age = byte.Parse(Console.ReadLine());

        Console.Write("Enter name 2: ");
        persons[2].Name = Console.ReadLine();
        Console.Write("Enter age 2: ");
        persons[2].Age = byte.Parse(Console.ReadLine());

        for (int i = 0; i < 3; i++)
        Console.WriteLine(persons[i].Description);
        
        Console.WriteLine("Press any key to continue . . .");
        Console.ReadKey();
    }
}