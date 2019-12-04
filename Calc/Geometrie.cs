using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Geometrie
    {
        public static double Area_Circle(double radius)
        {
            double area = 2 * (new Konstanten().pi * (radius * radius));
            return area;
        }
        public static double Radius_Circle(double area)
        {
            double radius = new MathCalc().root(2, new Grundrechner().CalcConst(area.ToString() + "/" + new Konstanten().pi.ToString()));
            return radius;
        }

        /// <summary>
        /// Calculates the Sin
        /// Sin is calculated sin x = x − x³/3! + x^5/5! − x^7/7! + ...,
        /// for more see here http://mathonweb.com/help_ebook/html/algorithms.htm#cos
        /// </summary>
        private double sin(double x)
        {
            double sin = x;
            var calc = new MathCalc();
            for (int i = 3; i < 21; i += 4)
            {
                sin -= calc.Power(x, i) / calc.factorial(i) + calc.Power(x, i + 2) / calc.factorial(i + 2);
            }
            return sin;
        }
        /// <summary>
        /// Calculates the Cos 
        /// Cos is calculated cos x = x − x²/2! + x^4/4! − x^6/6! + ...,
        /// for more see here http://mathonweb.com/help_ebook/html/algorithms.htm#cos
        /// </summary>
        private double cos(double x)
        {
            var calc = new MathCalc();
            double cos = 1;
            for (int i = 2; i < 20; i += 4)
            {
                cos -= calc.Power(x, i) / calc.factorial(i) + calc.Power(x, i + 2) / calc.factorial(i + 2);
            }
            return cos;
        }
        public double Cos(double x)
        {
            return convertToRadiant(x, true);
        }
        public double Sin(double x)
        {
            return convertToRadiant(x, false);
        }
        private double convertToRadiant(double x, bool checkIfSin)
        {
            while (x > 360)
            {
                x -= 360;
            }
            if (x > 180)
            {
                x -= 180;
            }
            if (checkIfSin && x > 45)
            {
                x = 90 - x;
                x *= (new Konstanten().pi / 180);
                return sin(x);
            }
            else if (!checkIfSin && x > 45)
            {
                x = 90 - x;
                x *= (new Konstanten().pi / 180);
                return cos(x);
            }
            if (checkIfSin)
            {
                x *= (new Konstanten().pi / 180);
                return cos(x);
            }
            return sin(x);
        }
    }
}
