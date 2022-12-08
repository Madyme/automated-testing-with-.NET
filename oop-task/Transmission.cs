// type, number of gears, manufacturer

class Transmission {
    string type = "";
    int numOfGears = 6;
    string manufacturer = "";
    
    public Transmission (string type, int numOfGears, string manufacturer) {
        Type = type; NumOfGears = numOfGears; Manufacturer = manufacturer;
    }

    public string Type {get; set;}
    public int NumOfGears {get; set;}
    public string Manufacturer {get; set;}
}