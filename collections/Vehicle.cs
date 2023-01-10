class Vehicle {
    public int EnginePower {get; set;}
    public int EngineVolume{get; set;}
    public string? Type{get; set;}
    public string? EngineSerialNum{get; set;}
    public string? TransmisType{get; set;} 

    public Vehicle(int engPower, int engVolume, string type, string engSerialNum, string transmType) {
        EnginePower = engPower;
        EngineVolume = engVolume;
        Type = type;
        EngineSerialNum = engSerialNum;
        TransmisType = transmType;
    }
}