class Car : Vehicle {
    public string Name{get; set;}
    public string BrandName{get; set;}

    public Car(string name, string brandName, int engPower, int engVolume, string type,
               string engSerialNum, string transmType) 
               : base(engPower, engVolume, type, engSerialNum, transmType) {

                    Name = name;
                    BrandName = brandName;
    }
}