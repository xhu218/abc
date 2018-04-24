using System;
using static System.Console;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            var x = 1001;
            try
            {
                throw new Exception();
            }
            catch (Exception ex)when(x==100)
            {

                WriteLine("abc");

            }
            Console.Read();
        }
    }
}
