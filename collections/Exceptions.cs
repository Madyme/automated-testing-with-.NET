public class InitializationException : ArgumentException
{
    public int Value { get; }
    public InitializationException(string message, int val) : base(message)
    {
        Value = val;
    }
}

public class RemoveAutoException : Exception
{
    public RemoveAutoException(string message) : base(message) { }
}

public class GetAutoByParameterException : Exception
{
    public GetAutoByParameterException(string message) : base(message) { }
}

public class UpdateAutoException : Exception
{
    public UpdateAutoException(string message) : base(message) { }
}