using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Generics
{
    internal class Maximum<T> where T : IComparable
    {
        public void Max(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine(firstValue+" is Maximum");
            }
            if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) >= 0 && secondValue.CompareTo(firstValue) > 0 ||
                secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) >= 0)
            {
                Console.WriteLine(secondValue + " is Maximum");
            }
            else
            {
                Console.WriteLine(thirdValue + " is Maximum");
            }

        }
        
    }
}
