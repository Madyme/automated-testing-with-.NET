public class Scooter : Vehicle {
    public int NumberOfSeats{get; set;}

    public void GetScooterInfo() {
        GetVehicleInfo();
        Console.Write("How many seats are there in ypur scooter: ");
        this.NumberOfSeats = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayScooterInfo() {
        DisplayVehicleInfo();
        Console.WriteLine($"The scooter has {NumberOfSeats} seats");
    }
    
}