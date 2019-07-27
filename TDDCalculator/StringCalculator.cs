using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDCalculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int Result = 0;
            if ("".Equals(numbers)) return 0;
            if (int.TryParse(numbers,out Result)) return Result;
            char Deliminiter;
            if (numbers.Contains(",") || numbers.Contains("\n"))
            {
                string[] array = numbers.Split( new char[2] { ',' , '\n' } );
                Result = 0;
                foreach (string number in array) Result = Result + Convert.ToInt32(number);
                return Result;
            }
            return -1;
        }
        public int subtract(string numbers)
        {
            if (numbers == null) return 0;
            if ("".Equals(numbers)) return 0;
            return -1;
        }
    }
}
