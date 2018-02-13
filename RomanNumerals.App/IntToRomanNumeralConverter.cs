using System.Collections.Generic;

namespace RomanNumerals.App
{
    public class IntToRomanNumeralConverter
    {
        List<string> ThouLetters = new List<string> { "", "M", "MM", "MMM", "MMMM" }; //using a list
        List<string> HundLetters = new List<string> { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] TensLetters = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }; //using a string
        Dictionary<int, string> OnesLetters = new Dictionary<int, string> //using dictionary
        {
            {0, ""},
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"},
            {5, "V"},
            {6, "VI"},
            {7, "VII"},
            {8, "VIII"},
            {9, "IX"},
        };

        public RomanNumeral Convert(string input)
        {
            var result = new RomanNumeral();

            //check if string can be converted to a number, if so convert to number 
            var isNum = int.TryParse(input, out int number);

            if (isNum && number > 0)
            {
                // Thousands
                int place;
                place = number / 1000;
                result.Numeral += ThouLetters[place];
                number %= 1000;

                // Hundreds
                place = number / 100;
                result.Numeral += HundLetters[place];
                number %= 100;

                // Tens.
                place = number / 10;
                result.Numeral += TensLetters[place];
                number %= 10;

                // Ones
                result.Numeral += OnesLetters[number];

                return result;

            }
            else if (isNum && number <= 0)
            {
                throw new System.ArgumentException($"Number must be greater than zero", input);
            }
            else
            {
                throw new System.ArgumentException($"{input} is not a valid number", input);
            }
        }         
    }

    public class RomanNumeral
    {
        public string Numeral { get; set; }
    }
}
