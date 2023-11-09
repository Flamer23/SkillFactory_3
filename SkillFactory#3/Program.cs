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


        }
    }
}