using System;
using System.Configuration;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = ConfigurationManager.AppSettings["name"];
            Console.WriteLine("Hello, " + name);
            Console.ReadKey();
        }
    }
}
