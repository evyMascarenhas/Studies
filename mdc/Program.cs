using System;

namespace mdc
{
    class Program
    {
        private  int GDC(int m, int n)
        {
            int i;

            if (n == 0) return m;
            return GDC(n, m % n);
        }

        public int GeneralizedGCD(int num, int[] arr)
        {
            // WRITE YOUR CODE HERE
            int result = arr[0];
            for (int i = 1; i < num; i++)
            {
                result = GDC(result, arr[i]);
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
