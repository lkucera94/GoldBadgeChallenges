using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThanksgivingConsole
{
    public class Thanksgiving
    {
        public string MainCourse { get; set; }
        public string SideDish { get; set; }
        public int Guests { get; set; }
        public bool Vegan { get; set; }

        public Thanksgiving(string course, string side, int guests, bool vegan)
        {
            MainCourse = course;
            SideDish = side;
            Guests = guests;
            Vegan = vegan;
        }
        public Thanksgiving()
        {

        }
    }
}
