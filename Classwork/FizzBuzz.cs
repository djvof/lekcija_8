using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    public class FizzBuzz
    {
        public string GetNumber(int number)
        {

            string text = "";

            if (number % 3 == 0)
            {
                text += "Fizz";
            }

            if (number % 5 == 0)
            {
                text += "Buzz";
            }

            if (string.IsNullOrWhiteSpace(text))
            {
                return number.ToString();
            }

            return text;
        }

    }
}
