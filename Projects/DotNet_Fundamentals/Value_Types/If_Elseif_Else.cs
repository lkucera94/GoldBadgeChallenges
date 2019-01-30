using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Types
{
    [TestClass]
    public class If_Elseif_Else
    {
        [TestMethod]
        public void If_Else()
        {
            if (2 != 2)
            {
                Console.WriteLine("Of course those are equal");
            }
            DateTime birthday = new DateTime(1991, 1, 9);
            DateTime date = DateTime.Now;

            if (birthday.Month == date.Month && birthday.Day == date.Day)
            {
                Console.WriteLine("Happy Birthday!");
            }
            else
            {
                Console.WriteLine("It is unfortunately not your birthday");
            }
            int age = 15;
            if (age <= 18)
            {
                Console.WriteLine("You're a kid");
            }
            else if (age > 25 && age <= 50)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 18 && age < 25)
            {
                Console.WriteLine("You're kind of an adult");
            }
            else
            {
                Console.WriteLine("You're old");
            }
        }
        [TestMethod]
        public void IfElseChallenge()
        {
            //{
            //    Console.WriteLine("Are you a coder? Type yes or no");
            //    string answer = Console.ReadLine();

            //    string y = "yes";
            //    if (answer == y)
            //}
            //{
            //    Console.WriteLine("That's awesome!");
            //}
            //else
            //{
            //    Console.WriteLine("You should try it out");
            }
        }
    }
