using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximumProblem
{
    public class FindMaxString
    {
        public static string CheckMaxString(string firststring, string secondstring, string thirdstring)

        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0)
            {
                return firststring;
            }
            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0)
            {
                return secondstring;
            }
            if (thirdstring.CompareTo(thirdstring) > 0 && thirdstring.CompareTo(secondstring) > 0)
            {
                return thirdstring;
            }
            throw new Exception("firstNumber , secondNumber , thirdNumber are same");
        }
    }
}
