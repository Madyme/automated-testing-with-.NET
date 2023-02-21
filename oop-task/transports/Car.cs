public class Car : Vehicle {

    public string? CarBodyType {get; set;}
    public string? CarModel {get; set;}

    public void GetCarInfo() {
        GetVehicleInfo();
        Console.Write("Enter car model: ");
        this.CarModel = Console.ReadLine();
        Console.Write("Enter car body type: ");
        this.CarBodyType = Console.ReadLine();
    }

    public void DisplayCarInfo() {
        DisplayVehicleInfo();
        Console.WriteLine($"The car has {CarModel} model,\n {CarBodyType} body type");
    }

}