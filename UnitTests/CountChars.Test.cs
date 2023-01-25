using CharNS;

public class Chars_Test_CountNumOfChars
{
    private readonly Chars _countChar;

    public Chars_Test_CountNumOfChars() {
        
        // arrange
        _countChar = new Chars();
    }

    [Theory]
    [InlineData("madina")]
    [InlineData("823790000saj")]
    [InlineData("abababbb")]
    [InlineData("mlasdaaa")]
    [InlineData("^^#$%@#")]
    public void CountMaxDiff_OutputShouldBe6(string input)
    {
    
        // act
        var result = _countChar.CountMaxDiff(input);

        // assert
        Assert.Equal(6, result);

    }

    [Theory]
    [InlineData("mad")]
    [InlineData("790000s")]
    [InlineData("aba")]
    [InlineData("mlaaaa")]
    [InlineData("^^#$")]

    public void CountMaxDiff_OutputShouldBe3(string input)
    {
    
        // act
        var result = _countChar.CountMaxDiff(input);

        // assert
        Assert.Equal(3, result);

    }

    [Fact]
    public void CountMaxDiff_OutputShouldBe0()
    {
    
        // act
        var result = _countChar.CountMaxDiff("");

        // assert
        Assert.Equal(0, result);

    }

    [Theory]
    [InlineData("AAabhjsa")]
    [InlineData("790000ssslzsd")]
    [InlineData("bbjshaaa")]

    public void CountMaxEqualLetters_OutputShouldBe3(string input) {
        // act
        var actual = _countChar.CountMaxEqualLetters(input);

        // assert
        Assert.Equal(3, actual);
    }

    [Fact]

    public void CountMaxEqualLetters_OutputShouldBe0() {
        // act
        var actual = _countChar.CountMaxEqualLetters("");

        // assert
        Assert.Equal(0, actual);
    }

    [Theory]
    [InlineData("39888889")]
    [InlineData("733933333")]
    [InlineData("83477777")]

    public void CountMaxEqualNum_OutputShouldBe5(string input) {
        // act
        var actual = _countChar.CountMaxEqualNum(input);

        // assert
        Assert.Equal(5, actual);
    }
    [Fact]
    public void CountMaxEqualNum_WronFormatInput() {
       // act & assert 
       Assert.Throws<ArgumentException>(() => _countChar.CountMaxEqualNum("AAab398hjsa"));
    }
}