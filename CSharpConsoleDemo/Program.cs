using System;
using Newtonsoft.Json;

namespace CSharpConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {            
            var test = new StudentTest();

            test.SetName("felix");

            test.GetName();

            test.SetAge();

            Console.ReadKey();
        }
    }
}
