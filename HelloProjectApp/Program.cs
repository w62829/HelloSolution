using System;
using HelloClassLibrary1;
using Jagiela;

namespace HelloProjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var instance = new HelloClass();
            var ring = new LordOfTheRings();
            ring.ShowYourself();
        }
    }
}
