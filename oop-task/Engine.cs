
// Engine engine = new Engine (1800, 50, "petrol", "PJ123456");
// engine.ShowEngineInfo();
class Engine {
    int power = 0;
    int volume = 0;
    string type = "";
    string serialNum = "";

    public Engine (int power, int volume, string type, string serialNum) {
        Power = power;
        Volume = volume;
        Type = type;
        SerialNum = serialNum;
    }

    public int Power {get; set;}
    public int Volume {get; set;}
    public string Type {get; set;}

    public string SerialNum {get; set;}

    public void ShowEngineInfo() {
        Console.WriteLine($"Engine power: {power} Engine volume: {volume} Engine type {type} Engine serial number: {serialNum}");
    }
}

