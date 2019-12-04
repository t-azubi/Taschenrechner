using System;
using System.Collections.Generic;

namespace Taschenrechner
{
    public class MathCalc
    {
        /// <summary>
        /// Calc the Power of the Num by the Pow
        /// </summary>
        public double Power(double num, double pow)
        {
            if (pow % 1 == 0)
            {
                double result = 1;
                if (pow > 0)
                {
                    for (double i = 1; i <= pow; ++i)
                    {
                        result *= num;
                    }
                }
                else if (pow < 0)
                {
                    for (double i = -1; i >= pow; --i)
                    {
                        result /= num;
                    }
                }
                return result;
            }
            var split = splitExp(pow);
            var wholeNumber = split.Item1;
            var decimalNumber = split.Item2;
            var d2f = DoubleToFraction(decimalNumber);
            var fractionTop = d2f.Item1;
            var fractionBottom = DoubleToFraction(decimalNumber).Item2;
            return Power(num, wholeNumber) * root(fractionBottom, Power(num, fractionTop));
        }
        /// <summary>
        /// Find all PrimeNumber between Bottom and Top Border.
        /// Test if i is divisible between 2 and i -1 if yes then its not a primenumber
        /// </summary>
        /// <param name="bottom border"></param>
        /// <param name="top border"></param>
        /// <returns>List of int with all Primenumbers between botom and top</returns>
        public List<int> Primenumber(int bottom, int top)
        {
            var flag = 1;
            List<int> output = new List<int>();
            for (int i = bottom; i < top; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    output.Add(i);
                }
            }
            return output;
        }
        /// <summary>
        /// Do 500 itteration and try to get close to the root 
        /// 
        /// </summary>
        public double root(double exp, double rad)
        {
            double guess = ((1) > (rad / exp) ? (1) : (rad / exp));

            for (int i = 0; i < 500; i++)
                guess -= (Power(guess, exp) - rad) / (exp * Power(guess, exp - 1));

            return guess;
        }
        /// <summary>
        /// Splits the Inputted Number in natural number and remaining float 
        /// </summary>
        public (int, double) splitExp(double exp)
        {
            var Y = exp.ToString();
            if (Y.IndexOf(',') == -1)
            {
                Y += ",0";
            }
            var X = Y.Split(',');
            return (Convert.ToInt32(X[0]), Convert.ToDouble("0," + X[1]));

        }
        /// <summary>
        /// Following the sigmanotation https://en.wikipedia.org/wiki/Logarithm#Power_series
        /// </summary>
        public double LN(double X)
        {
            var x = Convert.ToDouble(X);
            double guess = 0f, oldGuess = 0f;
            int itterationCounter = 0;
            do
            {
                oldGuess = guess;
                guess = guess + Power((x - 1) / (x + 1), 2 * itterationCounter + 1) / (2 * itterationCounter + 1);
                itterationCounter++;
            } while ((oldGuess != guess));
            return guess * 2;
        }
        /// <summary>
        ///  Clac the LOG of any base to any exponent
        /// </summary>
        public double LOG(double Exponent, double Base)
        {
            return LN(Exponent) / LN(Base);
        }
        /// <summary>
        /// Calculates the factorial from the Input
        /// </summary>
        public int factorial(int X)
        {
            if (X == 0)
            {
                return 1;
            }
            return X * factorial(X - 1);
        }

        /// <summary>
        ///  Converts a float point number into a fraction
        ///  You only need to input num
        ///  
        ///  See here https://en.wikipedia.org/wiki/Euclidean_algorithm
        /// </summary>
        /// <returns> 2 Integers </returns>
        public (long, long) DoubleToFraction(double decimalSourceNumber, double precision = 0.0001, int maxIterations = 50)
        {
            double[] Denominators = new double[maxIterations + 2];
            Denominators[0] = 0;
            Denominators[1] = 1;
            double decimalNumber = decimalSourceNumber;
            double Numerator = 1;
            long iterationCount = 1;

            // that are the numbers befor the decimal point
            long wholeNumberPart = (long)decimalSourceNumber;
            // that are the numbers after the decimal point
            double origninalDecimalNumberPart = decimalSourceNumber - Convert.ToDouble(wholeNumberPart);

            // with each iteration this value comes closer to 0 but is never 0.
            // rule: approximateValue > 0 
            var approximateValue = ABS((Numerator / Denominators[iterationCount] + (long)decimalSourceNumber) - decimalSourceNumber);
            while (iterationCount < maxIterations && approximateValue > precision)
            {
                iterationCount++;
                wholeNumberPart = (long)decimalNumber;
                var decimalNumberPart = decimalNumber - wholeNumberPart;
                // the decimal number is now between 1 and lower 10
                // because an excat match is 1 and a 0.9xxx is near 10 but never 10
                decimalNumber = 1 / decimalNumberPart;
                // a = q0 * b + r0
                // b = q1 * r0 + r1
                Denominators[iterationCount] = Denominators[iterationCount - 1] * (long)decimalNumber + Denominators[iterationCount - 2];

                var X = origninalDecimalNumberPart * Denominators[iterationCount];
               // mathematicly round it up to the next number if greater or even than .5
                Numerator = (long)(X + 0.5);
                approximateValue = ABS((Numerator / Denominators[iterationCount] + (long)decimalSourceNumber) - decimalSourceNumber);
            }
            return (Convert.ToInt64(Numerator + ((long)decimalSourceNumber * Denominators[iterationCount])), Convert.ToInt64(Denominators[iterationCount]));
        }
        /// <summary>
        /// returns the absolute value from imput
        /// </summary>
        public double ABS(double X)
        {
            if (X < 0)
            {
                return X * -1;
            }
            else
                return X;
        }
    }
    public class Konstanten
    {
        /// <summary>
        /// 2,71828
        /// </summary>
        public double e = new Grundrechner().CalcConst("410105312 / 150869313");
        /// <summary>
        /// 3,14159
        /// </summary>
        public double pi = new Grundrechner().CalcConst("21053343141 / 6701487259");
        /// <summary>
        /// 1,61803
        /// </summary>
        public double φ = new Grundrechner().CalcConst("( 1 + " + new MathCalc().root(2, 5).ToString() + ") / 2 ");
    }
}

