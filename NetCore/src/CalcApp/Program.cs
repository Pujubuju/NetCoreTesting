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
                Console.WriteLine(calculator.Add("2", "6"));
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong arguments.");
            }
        }
    }
}
