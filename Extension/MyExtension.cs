using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension
{
    public static class MyExtension
    {
        public static int SummaDigit(this int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10; 

            }
            return sum;

        }
        public static ulong SummaWithReverse(this uint n)
        {
            
            char [] ch = n.ToString().ToCharArray();
            Array.Reverse(ch);
            return n + Convert.ToUInt32(new String(ch));

        }
        public static int CountNotLetter(this string str)
        {
            return new string(str.ToLower().Where(n => !(n >= 97 && n <= 122)).ToArray()).Length;
        }
        public static bool IsDayOff(this DayOfWeek day)
        {
           switch(day)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    return true;
                default:
                    return false;
            }
        }
        public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> numbers)
        {
            foreach (int n in numbers)
                if (n % 2 == 0 && n > 0)
                {
                    yield return n;
                }
        }
    }
}
