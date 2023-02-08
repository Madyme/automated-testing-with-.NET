class InitializationException : ArgumentException {

    public int Value {get;}
    public InitializationException(string message, int val) : base(message) {
        Value = val;
    }
}

class RemoveAutoException : Exception {
    public RemoveAutoException(string message) : base(message) {
        
    }
}

class GetAutoByParameterException : Exception {
    public GetAutoByParameterException(string message) : base(message) {
        
    }
}

class UpdateAutoException : Exception {
    public UpdateAutoException(string message) : base(message) {
        
    }
}