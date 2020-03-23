using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VINLibrary
{
    public static class NumberParser
    {
        public static dynamic Parse( string input, ref Type inputType )
        {
            dynamic output = 0;

            if (inputType == typeof(int))
            {
                Int32.TryParse(input, out int parseOut);

                output = parseOut;

                return output;
            }
            else if (inputType == typeof(double))
            {
                Double.TryParse(input, out double parseOut);

                output = parseOut;

                return output;
            }
            else
            {
                throw new Exception("Type doesnt match");
            }
        }

        public static dynamic Parse<T>( string input )
        {
            dynamic output = 0;

            if (typeof(T) == typeof(int))
            {
                Int32.TryParse(input, out int parseOut);

                output = parseOut;

                return output;
            }
            else if (typeof(T) == typeof(double))
            {
                Double.TryParse(input, out double parseOut);

                output = parseOut;

                return output;
            }
            else
            {
                throw new Exception("Type doesnt match");
            }
        }
    }
}
