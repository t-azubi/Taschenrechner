using Taschenrechner;
using Xunit;

namespace GrundRechnerTest
{
    public  class TestInforechner
    {
        [Fact]
        public void TestBinToOther()
        {
            string Bin, Octal, Dec, Hexa;
            Bin = "110010";
            Octal = "62";
            Dec = "50";
            Hexa = "32";
           var result = new Informatikrechner().NumberSystemConverter(Bin, string.Empty, string.Empty, string.Empty, string.Empty);
           Assert.True(Bin == result[0]);
           Assert.True(Octal == result[2]);
           Assert.True(Dec == result[3]);
           Assert.True(Hexa == result[4]);
        }
    }
}
