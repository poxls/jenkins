using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace jenkins
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
        }
    }
}
