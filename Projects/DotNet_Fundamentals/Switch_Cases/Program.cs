using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On a scale of 1 to 5, how are you feeling today?");
            string feelingAsString = Console.ReadLine();
            int feeling = int.Parse(feelingAsString);

            switch (feeling)
            {
                case 1:
                    Console.WriteLine("Oh no, that's terrible");
                    break;
                case 2:
                    Console.WriteLine("Uh oh");
                    break;
                case 3:
                    Console.WriteLine("That's good");
                    break;
                case 4:
                    Console.WriteLine("Awesome");
                    break;
                case 5:
                    Console.WriteLine("That's fantastic!");
                    break;
                default:
                    Console.WriteLine("That's off the scale");
                    break;
            }

            if (feeling == 1)
            {
                Console.WriteLine(" Oh no, that's terrible");
            }
            else if (feeling == 2)
            {
                Console.WriteLine("Uh oh");
            }
            else if (feeling == 3)
            {
                Console.WriteLine("That's good");
            }
            else if (feeling == 4)
            {
                Console.WriteLine("Awesome");
            }
            else if (feeling == 5)
            {
                Console.WriteLine("That's fantastic!");
            }
            else
            {
                Console.WriteLine("That's off the scale");
            }
            Console.ReadLine();
        }

        public enum GenderType { Male, Female, NonBinary }
        class SwitchStatements
        {
            public void SwitchAndEnum()
            {
                string lastName = "Wagner";
                string firstName = "Kate";

                GenderType gender = GenderType.Female;
                switch (gender)
                {
                    case GenderType.Male:
                        Console.WriteLine($"Welcome Mr.{lastName}");
                        break;
                    case GenderType.Female:
                        Console.WriteLine($"Welcome Mrs.{lastName}");
                        break;
                    case GenderType.NonBinary:
                        Console.WriteLine($"Welcome {firstName} {lastName}");
                        break;

                }


            }
        }
    }
}
