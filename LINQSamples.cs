using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpConcepts
{
    class LINQSamples
    {
        public int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        public void LessThanFive()
        {
            var lowNums = from num in numbers
                          where num < 5
                          select num;

            Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }
    }

}
