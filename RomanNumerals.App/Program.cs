using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var converter = new IntToRomanNumeralConverter();
            var result = converter.Convert(input);
            Console.WriteLine(result.Numeral);
            Console.ReadKey(); 
        }
    }
}
