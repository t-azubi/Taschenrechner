using System;
using System.Collections.Generic;
using System.Linq;

namespace Taschenrechner
{
    public class Informatikrechner
    {
        private string DecimalToHexadezimal(int decimalValue)
        {
            return DecimalToArbitrarySystem(decimalValue, 16);
        }
        private string DecimalToBinary(int decimalValue)
        {
            return DecimalToArbitrarySystem(decimalValue, 2);
        }
        private string DecimalToOctal(int decimalValue)
        {
            return DecimalToArbitrarySystem(decimalValue, 8);
        }
        private string DecimalToTernär(int decimalValue)
        {
            return DecimalToArbitrarySystem(decimalValue, 3);
        }
        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system (in the range [2, 36]).</param>
        /// <returns></returns>
        private static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }
        private int BinaryToDecimal(string binaryValue)
        {
            return Convert.ToInt32(binaryValue, 2);
        }
        private int HexadecimalToDecimal(string hexadecimalValue)
        {
            return Convert.ToInt32(hexadecimalValue, 16);
        }
        private int OctalToDecimal(string octalValue)
        {
            return Convert.ToInt32(octalValue, 8);
        }
        private int TernaryToDecimal(string ternaryValue)
        {
            var digits = ternaryValue.ToCharArray().ToList();
            double dec = 0;
            for (int i = 0; i < digits.Count; i++)
            {
                dec += Convert.ToInt16(digits[i].ToString()) * new MathCalc().Power(3, digits.Count- 1 -i);
            }
            return (int)dec;
        }
        /// <summary>
        /// Gives Back a List where item 0 is the Bin
        /// </summary>
        /// <param name="BinValue"></param>
        /// <param name="OctalValue"></param>
        /// <param name="decimalValue"></param>
        /// <param name="HexaValue"></param>
        /// <returns></returns>
        public List<string> NumberSystemConverter(string BinValue, string OctalValue, string decimalValue, string HexaValue, string TerValue)
        {
            List<string> result = new List<string>();

            if (BinValue != string.Empty)
            {
               var DecInt = BinaryToDecimal(BinValue);
                result.Add(BinValue);
                result.Add(DecimalToTernär(DecInt));
                result.Add(DecimalToOctal(DecInt));
                result.Add(DecInt.ToString());
                result.Add(DecimalToHexadezimal(DecInt));
                return result;
            }
            if (OctalValue != string.Empty)
            {
                var DecInt = OctalToDecimal(OctalValue);
                result.Add(DecimalToBinary(DecInt));
                result.Add(DecimalToTernär(DecInt));
                result.Add(OctalValue);
                result.Add(DecInt.ToString());
                result.Add(DecimalToHexadezimal(DecInt));
                return result;
            }
            if (decimalValue != string.Empty)
            {
                var DecInt = Convert.ToInt32(decimalValue);
                result.Add(DecimalToBinary(DecInt));
                result.Add(DecimalToTernär(DecInt));
                result.Add(DecimalToOctal(DecInt));
                result.Add(decimalValue);
                result.Add(DecimalToHexadezimal(DecInt));
                return result;
            }
            if (HexaValue != string.Empty)
            {
                var DecInt = HexadecimalToDecimal(HexaValue);
                result.Add(DecimalToBinary(DecInt));
                result.Add(DecimalToTernär(DecInt));
                result.Add(DecimalToOctal(DecInt));
                result.Add(DecInt.ToString());
                result.Add(HexaValue);
                return result;
            }
            if (TerValue != string.Empty)
            {
                var DecInt = TernaryToDecimal(TerValue);
                result.Add(DecimalToBinary(DecInt));
                result.Add(TerValue);
                result.Add(DecimalToOctal(DecInt));
                result.Add(DecInt.ToString());
                result.Add(DecimalToHexadezimal(DecInt));
                return result;
            }
            return result;
        }
    }
}
