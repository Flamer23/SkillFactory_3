using System.Xml.Linq;

namespace SkillFactory_3
{
    internal class Program
    {
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        static void Main(string[] args)
        {
            string MyName = "Jane";
            byte MyAge = 27;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.WriteLine("\t Привет,\n мир!");

            byte age = 21;
            Console.WriteLine($"Мой возраст {age}");

            string name = "Ilya";
            string favcolor = "red";
            Console.WriteLine("{0}\n {1}\n {2}", name, age, favcolor);

            string str = Console.ReadLine();

            double result = 10 % 3; 
            Console.WriteLine(result);

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);
            Console.ReadKey();
        }
    }
}