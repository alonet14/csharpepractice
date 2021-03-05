using System;

namespace csharppractice.main.Chapter02.NullHandling
{
    public class NullHandling
    {
        public static void displayNullState()
        {
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
        }
        
    }
}