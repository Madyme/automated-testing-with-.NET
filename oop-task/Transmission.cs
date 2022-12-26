// type, number of gears, manufacturer

interface ITransmission {
    void ShowTransmissionInfo();
}
class Transmission {
    
    public string? Type {get; set;}
    public int NumOfGears {get; set;} = 6;
    public string? Manufacturer {get; set;}

    public void ShowTransmissionInfo() {
        Console.WriteLine($"Trnsmission type: {Type}, \n transmission number of gears: {NumOfGears}, \n transmission manufacturer: {Manufacturer}");
    }

    public void GetTransmissionInfo() {
        Console.Write("Enter transmission type: ");
        this.Type = Console.ReadLine();
        Console.Write("How many gears are there in this transmission: ");
        this.NumOfGears = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the name of transmission manufacturer: ");
        this.Manufacturer = Console.ReadLine();
    }
}