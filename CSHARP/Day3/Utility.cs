namespace Day3
{
    public class Utility
    {
        public static void SwapByValue(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void SwapByRef(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static void Add(ref int a, ref int b, out int c)
        {
            c = a + b;
        }
    }
}