using System;
using System.Collections.Generic;
namespace Exercite02Chapter02
{
    class Program
    {
        static Type GetType<T>(T x)
        {
            return typeof(T);
        }

        static void Main(string[] args)
        {
            // string[] listType = new string[11]{"sbyte"};
            // sbyte, byte, short, ushort, int, uint, long,
            // ulong, float, double, and decimal
            string[] NameOfColumns = new string[4] {"Type", "Number Of Byte", "Min Value", "Max Values"};
            Console.WriteLine(
                format: "{0,-8} {1, 10} {2, 20} {3, 20}",
                arg: NameOfColumns);

            object[] sbyteInfo = new object[4]{"sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue};
            
            Console.WriteLine(
                format: "{0, -8} {1, 6} {2, 20} {3, 20}",
                arg: sbyteInfo
                );
            
           
        }
    }
}