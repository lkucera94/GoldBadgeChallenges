using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorRepository
    {
        //Want a method that adds
        public int AddTwoNumbers(int pizza, int pie)
        {
            int pizzaPie = pizza + pie;
            return pizzaPie;
        }
        //Want a method that subtracts
        public int SubtractTwoNumbers(int race, int track)
        {
            int raceTrack = race - track;
            return raceTrack;
        }

        //Want a method that multiplies
        public int MultiplyTwoNumbers(int disco, int ball)
        {
            int discoBall = disco * ball;
            return discoBall;
        }
        //Want a method that divides
        public int DivideTwoNumbers(int dog, int house)
        {
            int dogHouse = dog / house;
            return dogHouse;
        }
        
    }
}
