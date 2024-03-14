namespace VendingMachine.Tests;
using Coin.Checker;
public class Parse
{
    [Fact]
    public void Parse_IfItChecksForUnitError()
    {
        var coin = new Coins();

        Assert.Throws<FormatException>(() => coin.Parse("34"));
    }
    [Fact]
    public void Parse_IfItHasCorrectFormat()
    {
        var coin = new Coins();

        var exception = Record.Exception(() => coin.Parse("2E")); 
        Assert.Null(exception);
    }
    [Fact]
    public void Parse_IfItHasTwoOrMorePoints()
    {
        var coin = new Coins();

        Assert.Throws<FormatException>(() => coin.Parse("2.2.2E"));
    }
}