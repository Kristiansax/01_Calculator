﻿namespace _01_Calculator
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Sum(int[] a)
        {
            return a[0] + a[1];
        }
        public static int Multiply(int[] a)
        {
            int sum = 1;
            int x = a.Length;
            for (int i = 0; i < x; i++)
            {
                sum = a[i] * sum;
            }
            return sum;
        }
        public static int Power(int x, int y)
        {

        }
    }
}