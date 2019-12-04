using Taschenrechner;
using Xunit;

namespace GrundRechnerTest
{
        public class TestErrorHandling
        {
            [Fact]
            public void TestWrongInputWithoutNumbers()
            {
                var Equation = "()))))))))))))))))";
                Assert.True("(" == new ErrorHandlingTest().TestCheck(Equation));
            }
            [Fact]
            public void TestWrongInputWithoutNumbers2()
            {
                var Equation = "+++++++++++";
                Assert.True("+" == new ErrorHandlingTest().TestCheck(Equation));
            }
            [Fact]
            public void TestWrongInputWithoutBracketsTimes()
            {
                var Equation = "(*";
                Assert.True("(" == new ErrorHandlingTest().TestCheck(Equation));
            }
            [Fact]
            public void TestWrongInputWithoutNumbersBracketsDivide()
            {
                var Equation = "(/";
                Assert.True("(" == new ErrorHandlingTest().TestCheck(Equation));
            }
            [Fact]
            public void TestWrongInputWithoutNumbersBracketsplus()
            {
                var Equation = "(+";
                Assert.True("(" == new ErrorHandlingTest().TestCheck(Equation));
            }
            [Fact]
            public void TestWrongInputWithoutNumbersBracketsminusminus()
            {
                var Equation = "(--";
                Assert.True("(+" == new ErrorHandlingTest().TestCheck(Equation));
            }
            [Fact]
            public void TestWrongInputWithoutNumbersminusminusBrackets()
            {
                var Equation = "--(";
                var cor = new ErrorHandlingTest().TestCheck(Equation);
                Assert.True("+(" == cor);
            }
            [Fact]
            public void TestWrongInputLetters()
            {
                var Equation = "asdhwrtzasrdf";
                Assert.True("" == new ErrorHandlingTest().TestCheck(Equation));
            }
            [Fact]
            public void TestCorrecktLostClosedBrackets()
            {
                var Equation = "((2+2";
                Assert.True("((2+2))" == new ErrorHandlingTest().TestCorrect(Equation));
            }
            [Fact]
            public void TestCorrecktLostOpeningBrackets()
            {
                var Equation = "2+2))";
                Assert.True("((2+2))" == new ErrorHandlingTest().TestCorrect(Equation));
            }
        }
        public class ErrorHandlingTest : ErrorHandling
        {
            public string TestCheck(string Equation)
            {
                return checkForErrors(Equation);
            }
            public string TestCorrect(string Equation)
            {
                return CorrectEquation(Equation, CountBrackets(Equation, true), CountBrackets(Equation, false));
            }
        }
}
