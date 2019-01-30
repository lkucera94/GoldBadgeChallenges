using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("What is your first and last name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            string hello = "Hello";
            string greeting = hello + " " + name;
            string question = "Why do you like";
            Console.WriteLine($"{greeting}. {question} {food}?");
            string answer = Console.ReadLine();
            string closing = "Cool, thank you for the information!";
            Console.WriteLine(closing);
            Console.ReadLine();

      
            //int age = int. Parse(Console.Readline())
        }
    }
}
