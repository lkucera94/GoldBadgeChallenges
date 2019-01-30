using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Cases
{
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

