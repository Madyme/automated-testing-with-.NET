public abstract class Vehicle {
    private Engine engine;
    private Chassis chassis;
    private  Transmission transmission;

    public Vehicle() {
        engine = new Engine();
        chassis = new Chassis();
        transmission = new Transmission();
    }

    public abstract ShowInfo();
}