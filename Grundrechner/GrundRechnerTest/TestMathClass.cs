using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using Taschenrechner;
using Xunit;

namespace GrundRechnerTest
{
    public class TestMathClass
    {
        [Fact]
        public void Power2()
        {
            Assert.True(new MathTest().power(2, 2) == 4);
            Assert.True(new MathTest().power(5, 2) == 25);
            Assert.True(new MathTest().power(12, 2) == 144);
        }

        [Fact]
        public void PowerFloat()
        {
            Assert.True(new MathTest().power(16, 0.5) == 4);
            Assert.True(new MathTest().power(625, 0.5) == 25);
            Assert.True(new MathTest().power(25, 0.5) == 5);
        }
        [Theory]
        [InlineData(5.23, 523, 100)]
        [InlineData(0.333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333333, 1, 3)]
        public void Double2FractionTest(double input, int upnumber, int downnumber)
        {            
            var sourceNumber = input;

            var result = new MathTest().DoubleToFraction(sourceNumber);
            
            Assert.Equal(upnumber, result.Item1);
            Assert.Equal(downnumber, result.Item2);

        }
        [Fact]
        public void PowerNeg2()
        {
            Assert.True(new MathTest().power(2, -2) == 0.25);
            Assert.True(new MathTest().power(5, -2) == 0.04);
        }
        [Fact]
        public void primenumberTest()
        {
            var result = new MathCalc().Primenumber(1, 10);
            Assert.True(2 == result.First());
        }
        [Fact]
        public void Power10()
        {
            Assert.True(new MathTest().power(2, 10) == 1024);
            Assert.True(new MathTest().power(5, 10) == 9765625);
        }
        [Fact]
        public void Root2()
        {
            var root = new MathTest().RootTest(2, 9);
            Assert.True( root == 3);
            Assert.True(new MathTest().RootTest(2, 36) == 6);
        }
        [Fact]
        public void Root3()
        {
            Assert.True(new MathTest().RootTest(3, 27) == 3);
            Assert.True(new MathTest().RootTest(3, 1000) == 10);
        }
        [Fact]
        public void LN2()
        {
            Assert.True(new MathTest().naturalLN(2) == 0.69314718055994506);
        }
        [Fact]
        public void Faku5()
        {
            Assert.True(new MathTest().FakultätTest(5) == 120);
        }
        [Fact]
        public void LOG()
        {
            Assert.True(new MathTest().LOGTest(10, 10) == 1);
        }
        [Fact]
        public void Primenumber()
        {
            var top = 12;
            var bot = 5;
            var exp = new List<int> {5, 7, 11 };

            var res = new MathTest().PrimeNumberTest(bot, top);

            Assert.True(exp[2] == res[2]);
            Assert.True(exp[1] == res[1]);
            Assert.True(exp[0] == res[0]);
        }
    }
    public class MathTest : MathCalc
    {
        public double power(double num, double exp)
        {
            return Power(num, exp);
        }
        public double naturalLN(double x)
        {
            return LN(x);
        }
        public double LOGTest(double x, double y)
        {
            return LOG(x, y);
        }
        public int FakultätTest(int x)
        {
            return factorial(x);
        }
        public double RootTest(double exponent , double radikant)
        {
            return root(exponent,radikant);
        }
        public List<int> PrimeNumberTest(int bottomBorder, int topBorder)
        {
            return Primenumber(bottomBorder, topBorder);
        }
    }
    public class TestKonst
    {
        [Fact]
        public void EulerischerZahl()
        {
            var e = new KonstantenTest().e;
            Assert.True(e == 2.7182818284590451);
        }

        [Fact]
        public void Pi()
        {
            var pi = new KonstantenTest().pi;
            Assert.True(pi == 3.1415926535897931);
        }
        [Fact]
        public void GoldenerSchnitt()
        {
            var φ = new KonstantenTest().φ;
            Assert.True(φ == 1.6180339887498949);
        }
    }
    public class KonstantenTest : Konstanten
    {

    }
}
