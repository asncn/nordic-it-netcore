using System;
using System.Dynamic;
using System.Linq;

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
        const int quantity = 3;
        string input = string.Empty;

        Person[] persons = new Person[quantity];
        for (int i = 0; i < quantity; i++)
        {
            persons[i] = new Person();

            Console.WriteLine($"Enter name {i}: ");
            input = Console.ReadLine();
            persons[i].Name = input;

            Console.WriteLine($"Enter age {i}: ");
            input = Console.ReadLine();
            persons[i].Age = byte.Parse(input);
        }
        for (int i = 0; i < persons.Count(); i++)
        {
            Console.WriteLine(persons[i].Description);
        }
        Console.WriteLine("Press any key to continue . . .");
        Console.ReadKey();
    }
}