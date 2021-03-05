using System;
using static System.Console;

namespace DebuggingChapter04
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            double a = 4.5;
            double b = 5.5;
            double Answer = Add(a, b);
            WriteLine($"{a} + {b} = {Answer}");
            ReadLine();
        }
    }
}