
// Engine engine = new Engine (1800, 50, "petrol", "PJ123456");
// engine.ShowEngineInfo();
// interface IEngine  {
//     void ShowEngineInfo();
// }
public abstract class Engine {

    public int Power {get; set;}
    public int Volume {get; set;}
    public string? Type {get; set;}

    public string? SerialNum {get; set;}

    public abstract void GetEngineInfo();
    // {
    //     Console.Write("Enter engine power: ");
    //     this.Power = Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Enter engine volume: ");
    //     this.Volume = Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Enter engine type: ");
    //     this.Type = Console.ReadLine();
    //     Console.Write("Enter engine serial number: ");
    //     this.SerialNum = Console.ReadLine();
    // }
    // public void ShowEngineInfo() {
    //     Console.WriteLine($"Engine power: {Power}\n Engine volume: {Volume}\n Engine type {Type}\n Engine serial number: {SerialNum}");
    // }
}

