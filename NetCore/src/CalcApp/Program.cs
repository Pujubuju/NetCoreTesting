using System;
using Library;

namespace CalcApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                StringCalculator calculator = new StringCalculator();
                Console.WriteLine(calculator.Add(args[0], args[1]));
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong arguments.");
            }
        }
    }
}
