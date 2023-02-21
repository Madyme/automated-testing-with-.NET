public abstract class Vehicle {
    private Engine engine;
    private Chassis chassis;
    private  Transmission transmission;

    public Vehicle() {
        engine = new Engine();
        chassis = new Chassis();
        transmission = new Transmission();
        Console.WriteLine("vehicle constructor");
    }

    public void GetVehicleInfo() {
        engine.GetEngineInfo();
        chassis.GetChassisInfo(); 
        transmission.GetTransmissionInfo();
    }

    public void DisplayVehicleInfo() {
        engine.DisplayEngineInfo();
        chassis.DisplayChassisInfo();
        transmission.DisplayTransmissionInfo();
    }
}