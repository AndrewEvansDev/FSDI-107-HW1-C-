using System;


namespace DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 3, 5, 1, 10, 33 };

            Console.WriteLine(MathFunctions.SuckFish(myArr));
            Console.WriteLine(MathFunctions.YuckFish(myArr));
            Console.WriteLine(MathFunctions.MuckFish(myArr));
            Console.WriteLine(WordFunctions.GetReply());

        }
    }
}
