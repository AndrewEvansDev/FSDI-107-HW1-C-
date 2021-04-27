using System.Linq;

namespace DotNet
{
    class MathFunctions
    {
        public static int SuckFish(int[] arr)
        {

            return arr.Max();
        }

        public static int YuckFish(int[] arr)
        {
            return arr.Sum();
        }
        public static double MuckFish(int[] arr)
        {
            int num1 = SuckFish(arr);
            int num2 = YuckFish(arr);
            double num3 = (double)num1 / (double)num2;
            return num3;
        }
    }
}