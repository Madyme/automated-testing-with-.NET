class Truck : Vehicle {
    public string? TrailerType {get; set;}

    public Truck(string trailerType, int engPower, int engVolume, string type,
               string engSerialNum, string transmType) 
               : base(engPower, engVolume, type, engSerialNum, transmType)
                {
                    TrailerType = trailerType;
                }

}