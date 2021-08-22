using System;
using System.Collections.Generic;

namespace divisibleNumbers
{
    class Program
    {

        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            List<int> resultList = new List<int>();           
            foreach (int num in numbers)
            {
            if (num % divisor == 0)
                resultList.Add(num);
            }
            return resultList.ToArray();
        }

        static void Main(string[] args)
        {
            int[] result = DivisibleBy(new int[] {1,2,3,4,5,6}, 2);
            foreach(int i in result)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
