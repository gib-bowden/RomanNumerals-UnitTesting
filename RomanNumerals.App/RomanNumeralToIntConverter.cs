using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals.App
{
    public class RomanNumeralToIntConverter
    {
        Dictionary<string, int> Mapper = new Dictionary<string, int> //using dictionary
        {
            {"I", 1},
            {"V", 5},
            {"X", 10}
        };

        public int Convert(string input)
        {
            //check if string can be converted to a number, if so convert to number 
            var isNum = int.TryParse(input, out int number);
            var result = 0;  

            if (isNum)
                throw new System.ArgumentException($"Input must be a roman numeral", input);

            for (int i = 0; i < input.Length; i++)
                {
                    if (i < (input.Length - 1))
                    {
                        if (input[i].ToString() == "I" && (input[i + 1].ToString() == "V") || (input[i + 1].ToString() == "X"))
                        {
                            result -= Mapper[input[i].ToString()];
                        }
                        else
                        {
                            result += Mapper[input[i].ToString()];
                        }
                    }
                    else
                    {
                        result += Mapper[input[i].ToString()];
                    }                  
                }             

                return result;
        }
    }
}
