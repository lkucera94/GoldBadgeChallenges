using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Challenge
{
    public enum GenderType { Male, Female, Other}
    public class CustomerInformation
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }

        public CustomerInformation() { }

        public CustomerInformation(string name, int age, GenderType gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

       
    }

}
