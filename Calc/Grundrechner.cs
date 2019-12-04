using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Taschenrechner
{
    public class Grundrechner
    {
        public List<string> Rechenschritte = new List<string>();
        public string makeEquationSolvable(string equation)
        {
            equation = Regex.Replace(equation, @"\s+", "");
            equation = Regex.Replace(equation, @"--", "+");
            equation = Regex.Replace(equation, @"\*-", "x");
            equation = Regex.Replace(equation, @"\+-", "-");
            equation = Regex.Replace(equation, @"/-", "#");
            return equation;
        }
        public double CalcConst(string equation)
        {
            Operation operation = new Operation();
            if ((equation.Any(d => d == '(')))
            {
                equation = operation.calcBrackets(equation, out Rechenschritte);
                equation = makeEquationSolvable(equation);
                Rechenschritte.Add(equation);
                operation.Parse(equation);
                return operation.Solve();
            }
            else
            {
                operation.Parse(equation);
                return  operation.Solve();
            }
        }
        public double Solve(string equation, out List<string> Rechenschritte)
        {
            Rechenschritte = this.Rechenschritte;
            equation = makeEquationSolvable(equation);
            var othermultiplication = Regex.Match(equation, @"\d\(");
            if ((othermultiplication.Success))
            {
                equation = equation.Substring(0, othermultiplication.Index + 1) + "*" + equation.Substring(othermultiplication.Index + 1);
            }
            othermultiplication = Regex.Match(equation, @"\)\d");
            if ((othermultiplication.Success))
            {
                equation = equation.Substring(0, othermultiplication.Index + 1) + "*" + equation.Substring(othermultiplication.Index + 1);
            }
            Operation operation = new Operation();
            var result = 0.0;
            if ((equation.IndexOf('-') == 0))
            {
                equation = "0" + equation;
            }
            if (equation.Any(d => d == '('))
            {
                equation = operation.calcBrackets(equation, out Rechenschritte);
                equation = makeEquationSolvable(equation);
                Rechenschritte.Add(equation);
                operation.Parse(equation);
                result = operation.Solve();
            }
            else
            {
                operation.Parse(equation);
                result = operation.Solve();
            }
            return result;
        }
    }
    public class Operation
    {
        public List<string> Rechenschritte = new List<string>();
        public Operation LeftNumber { get; set; }
        public string Operator { get; set; }
        public Operation RightNumber { get; set; }
        private Regex additionSubtraction = new Regex("[-+]", RegexOptions.RightToLeft);
        private Regex multiplicationDivision = new Regex("[*/]", RegexOptions.RightToLeft);
        private Regex timesminus = new Regex(@"x", RegexOptions.RightToLeft);
        private Regex dividedminus = new Regex(@"#", RegexOptions.RightToLeft);
        public void Parse(string equation)
        {
            if ((equation == String.Empty))
            {
                equation = "0";
            }
            var operatorLocation = timesminus.Match(equation);
            if ((!operatorLocation.Success))
            {
                operatorLocation = dividedminus.Match(equation);
            }
            if ((!operatorLocation.Success))
            {
                operatorLocation = additionSubtraction.Match(equation);
            }
            if ((!operatorLocation.Success))
            {
                operatorLocation = multiplicationDivision.Match(equation);
            }
            if ((operatorLocation.Success))
            {
                Operator = operatorLocation.Value;
                LeftNumber = new Operation();
                RightNumber = new Operation();
                LeftNumber.Parse(equation.Substring(0, operatorLocation.Index));
                RightNumber.Parse(equation.Substring(operatorLocation.Index + 1));
            }
            else
            {
                Operator = "v";
                result = double.Parse(equation);
            }
        }
        private double result;
        public double Solve()
        {
            switch (Operator)
            {
                case "v":
                    break;
                case "#":
                    result = LeftNumber.Solve() / RightNumber.Solve() * -1;
                    break;
                case "x":
                    result = LeftNumber.Solve() * RightNumber.Solve() * -1;
                    break;
                case "+":
                    result = LeftNumber.Solve() + RightNumber.Solve();
                    break;
                case "-":
                    result = LeftNumber.Solve() - RightNumber.Solve();
                    break;
                case "*":
                    result = LeftNumber.Solve() * RightNumber.Solve();
                    break;
                case "/":
                    result = LeftNumber.Solve() / RightNumber.Solve();
                    break;
                default:
                    break;
            }
            return result;
        }

        public string calcBrackets(string calculation, out List<string> Rechenschritte)
        {
            Rechenschritte = this.Rechenschritte;
            Operation operation = new Operation();
            var indexOfOpening = -1;
            var indexOfClosing = calculation.IndexOf(')');
            if ((indexOfClosing != -1))
            {
                indexOfOpening = calculation.Substring(0, indexOfClosing).LastIndexOf('(');
            }
            if ((indexOfClosing == -1 && indexOfOpening == -1))
            {
                operation.Parse(calculation);
                var result = operation.Solve();
                return result.ToString();
            }
            else
            {
                Rechenschritte.Add(calculation);
                calculation = calculation.Substring(0, indexOfOpening) + calcBrackets(calculation.Substring(indexOfOpening + 1, indexOfClosing - indexOfOpening - 1), out Rechenschritte) + calculation.Substring(indexOfClosing + 1);
                if ((calculation.Any(d => d == ')')))
                {
                    calculation = calcBrackets(calculation, out Rechenschritte);
                }
            }
            return calculation;

        }
    }
}
