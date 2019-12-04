using System;
using System.Collections.Generic;
using Taschenrechner;
using Xunit;

namespace GrundRechnerTest
{
    public class GrundrechnerTests
    {
        [Fact]
        public void EquationWithoutDecimalandAndBracketsAddition()
        {
            var result = new GrundrechnerTest().TestSolve("10 + 10");
            Assert.True(result == 20);
        }
        [Fact]
        public void EquationWithoutDecimalandAndBracketsDivision()
        {
            var result = new GrundrechnerTest().TestSolve("10 / 10");
            Assert.True(result == 1);
        }
        [Fact]
        public void EquationWithoutDecimalandAndBracketsMultiplication()
        {
            var result = new GrundrechnerTest().TestSolve("10 * 10");
            Assert.True(result == 100);
        }
        [Fact]
        public void EquationWithoutDecimalandAndBracketsSubdraction()
        {
            var result = new GrundrechnerTest().TestSolve("20 - 10");
            Assert.True(result == 10);
        }
        [Fact]
        public void EquationWithoutDecimalandAndBracketsAllesVermischt()
        {
            var result = new GrundrechnerTest().TestSolve("10 + 10 - 20");
            Assert.True(result == 0);
        }
        [Fact]
        public void EquationWithoutDecimalandAndBracketsPunktVorStrich()
        {
            var result = new GrundrechnerTest().TestSolve("20 - 10 * 2");
            Assert.True(result == 0);
        }
        [Fact]
        public void EquationWithoutDecimalandOneBracket()
        {
            var result = new GrundrechnerTest().TestSolve("20 - ( 10 + 2 )");
            Assert.True(result == 8);
        }
        [Fact]
        public void EquationWithoutDecimalandThreeBracket()
        {
            var result = new GrundrechnerTest().TestSolve("20 - ( 10 + ( 2 * ( 2 + 3 ) ) )");
            Assert.True(result == 0);
        }
        [Fact]
        public void EquationDecimalRightlastDecimal()
        {
            var result = new GrundrechnerTest().TestSolve("10,5 + 3,5");
            Assert.True(result == 14);
        }
        [Fact]
        public void EquationDecimal()
        {
            var result = new GrundrechnerTest().TestSolve("10,5 + 3,5 + 6");
            Assert.True(result == 20);
        }
        [Fact]
        public void DoubleNegative()
        {
            var result = new GrundrechnerTest().TestSolve("2 - -2");
            Assert.True(result == 4);
        }
        [Fact]
        public void DoubleNegativeWithOtherOperators()
        {
            var result = new GrundrechnerTest().TestSolve("2 - -2 * 2 + 2");
            Assert.True(result == 8);
        }
        [Fact]
        public void EquationNegativeDecimal()
        {
            var result = new GrundrechnerTest().TestSolve("-1,5 + 1 - -2 ");
            Assert.True(result == 1.5);
        }
        [Fact]
        public void EquationNegativeMultiplication()
        {
            var result = new GrundrechnerTest().TestSolve(" 1 * -2 ");
            Assert.True(result == -2);
        }
        [Fact]
        public void DevidedByMinus()
        {
            var result = new GrundrechnerTest().TestSolve(" 7 / -2");
            Assert.True(result == -3.5);
        }
        [Fact]
        public void Multiplicationwithoutasteriks()
        {
            var result = new GrundrechnerTest().TestSolve(" 1 ( 1 - 2 )");
            Assert.True(result == -1);
        }
        [Fact]
        public void sameBracketLevels()
        {
            var result = new GrundrechnerTest().TestSolve("( ( 12 - 6 ) * 2 ) + ( ( 4 - 8 ) - 9 )");
            Assert.True(result == -1);
        }
    }
    public class GrundrechnerTest :  Grundrechner
    {
        public double TestSolve(string Equation)
        {
            List<string> list = new List<string>();
            return Solve(Equation, out list);
        }
    }
}
