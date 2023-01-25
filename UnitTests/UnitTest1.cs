// namespace UnitTests;

using ProgramNS;

public class Program_CountMaxDiff
{

    private readonly Program _countChar;

    public Program_CountMaxDiff() {
        _countChar = new Program();
    }
    [Fact]
    public void CountMaxDiff_InputIsMadina()
    {
    
        var result = _countChar.CountMaxDiff("madina");

        Assert.Equal(6, result);

    }

    [Fact]

    public void CountMaxEqualLetters_InputIs() {
        var actual = _countChar.CountMaxEqualLetters("AAabhjsa");
        Assert.Equal(3, actual);
    }

    [Fact]

    public void CountMaxEqualNum_InputIs00923() {
        var actual = _countChar.CountMaxEqualNum("00923");
        Assert.Equal(2, actual);
    }
}