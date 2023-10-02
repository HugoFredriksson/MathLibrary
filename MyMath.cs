using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MyMath
    {
        public int Add(string a, string b)
        {
            int tal1, tal2;
            try
            {
                tal1 = int.Parse(a);
                tal2 = int.Parse(b);
                return tal1 + tal2;
            }
            catch(Exception e) 
            {
                throw new FormatException("Du måste ha siffror");
            }
        }
       public bool IsEqual(int a, int b) 
        {
            return (a == b);
        }
        public int Difference(int a, int b)
        {
            //skillnaden mellan a och b
            if (a > b)
            {
                return a - b; 
            }
            //om a = 4 och b = 2 -> 2
            return b - a;           
            //om a = 2 och b = 4 -> 2
        }
        public int Difference(string a, string b)
        {
            //skillnaden mellan a och b
            int integerA = int.Parse(a);
            int integerB = int.Parse(b);
            //om a = 4 och b = 2 -> 2
            if (integerA > integerB)
            {
                return integerA - integerB;
            }
            return integerB - integerA;
            //om a = 2 och b = 4 -> 2

            //talen ska även parsas 

            //Fel förväntas om man lägger in fel

        }
    }
    public class MyMath2
    {
        public double ConvertToFahrenheit(double c)
        {
            if (c < -273.15)
            {
                throw new ArgumentOutOfRangeException(paramName: "Temperature cant be lower than 0 kelvin");
            }
            double f = 1.8 * c + 32;
            return f;
        }
        public int CompareTo(int a, int b)
        {
            //om a > b --> 1

            //om a == b --> 0

            //om a < b --> -1
            return 0;
        }
    }
}
