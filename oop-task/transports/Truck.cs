public class Truck : Vehicle
{
    public string? TruckFuelType { get; set; }
    public string? TruckTrailerType { get; set; }

    public void GetTruckInfo() {
        GetVehicleInfo();
        Console.Write("Enter truck fuel type: ");
        this.TruckFuelType = Console.ReadLine();
        Console.Write("Enter truck trailer type: ");
        this.TruckTrailerType = Console.ReadLine();
    }

    public void DisplayTruckInfo() {
        DisplayVehicleInfo();
        Console.WriteLine($"The truck has {TruckFuelType} fuel type, {TruckTrailerType} trailer type");

    }
   
}
