#nullable enable
using System;

namespace NullHandlingProject
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address();
            address.Building = null;
            
            int NumberOfApples = 12;
            decimal PricePerApple = 0.35M;
            Console.WriteLine($"{NumberOfApples} is price {PricePerApple*NumberOfApples}");
        }
    }
}