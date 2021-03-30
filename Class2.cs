using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Project28
{
    class Class2
    {
        static void Main(string[] args)
        {
            GermanSheppard Max = new GermanSheppard();
            Console.WriteLine("Enter the Dog Name");
            Max.Name=Console.ReadLine();
            Console.WriteLine("Enter the Dog origin");
            Max.Origin = Console.ReadLine();
            Console.WriteLine("Please, enter the Dog's birth date");
            try //example of exception handling
            {
                Max.BirthDate = DateTime.Parse(Console.ReadLine());
            }
            catch
            {
                Max.BirthDate = DateTime.Now;
            }
            Max.output(Max.Name, Max.Origin, Max.BirthDate);
            Console.WriteLine();
            Max.sit(Max.Name);
            Max.eat();
            Max.sayHi();
        }
    }
    class Animal // example of private and access modifiers
    {
        private string name;
        private DateTime birthdate;
        private string origin;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Origin
        {
            set { origin = value; }
            get { return origin; }
        }
        public DateTime BirthDate
        {
            set { birthdate = value; }
            get { return birthdate; }
        }
    }
    class GermanSheppard: Animal,Dog //example of inheritance
    {
        public void eat()
        {
            Console.WriteLine("Dog eats");
        }
        public void drink()
        {
            Console.WriteLine("Dog drinks");
        }
        public void sit()
        {
            Console.WriteLine("Dog sits");
        }
        public void sayHi()
        {
            Console.WriteLine("Dog sends its regards");
        }
        public void eat(string DogName) //overloaded functions
        {
            Console.WriteLine($"{ DogName} eats");
        }
        public void drink(string DogName)
        {
            Console.WriteLine($"{DogName} drinks");
        }
        public void sit(string DogName)
        {
            Console.WriteLine($"{DogName} sits");
        }
        public void sayHi(string DogName)
        {
            Console.WriteLine($"{DogName} sends its regards");
        }
        public void output(string name, string origin, DateTime a)
        {
            Console.WriteLine($"The dog;s name is {name}, from {origin}, was born on {a}");
            Console.WriteLine($"{name} is Male and weighs 32.53 kilos and its size is Large");
        }
    }
    interface Dog //simple instance of interface
    {
        void eat();
        void drink();
        void sit();
        void sayHi();
    }
}
