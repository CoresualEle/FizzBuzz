using System;
using System.Globalization;
using FizzBuzz.Lib;

namespace FizzBuzz.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fizzHandler = new FizzHandler();
            var buzzHandler = new BuzzHandler();

            fizzHandler.AppendHandler(buzzHandler);

            Console.WriteLine("Enter Array Length:");
            int.TryParse(Console.ReadLine(),NumberStyles.Integer, new NumberFormatInfo(), out var arrayLength);

            var testArray = new int[arrayLength];

            for (var i = 0; i < testArray.Length; i++)
            {
                testArray[i] = (i + 1);
            }

            var result = fizzHandler.HandleEventArgs(new FizzBuzzEventArgs(testArray));

            var resultString = "";

            foreach (var s in result.ModifiedArray)
            {
                resultString += s + ";";
            }

            Console.WriteLine(resultString);
        }
    }
}