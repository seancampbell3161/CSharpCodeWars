using System;

namespace beastFeast
{
    class Program
    {

        public static bool Feast(string beast, string dish)
        {
            return beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(Feast("elephant", "eggplant"));
            System.Console.WriteLine(Feast("cobra", "cake"));
        }
    }
}
