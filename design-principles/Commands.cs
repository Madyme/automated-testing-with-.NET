// abstract Command class
public abstract class Command
{
    protected Car car = Car.GetInstance();
    
}

// concrete command classes
public class ShowCommand : Command
{

    public void Execute()
    {
        if( Car.brands.Count != 0 ||
            Car.cost.Count != 0 ||
            Car.model.Count != 0 ||
            Car.quantity.Count != 0) {
                Console.WriteLine($"total count of brends: {Car.brands.Count}");
                Console.WriteLine($"total count of cars: {car.CountCars()}");
                Console.WriteLine($"average cost of car: {car.CountAveragePrice()}");
            } else {
                Console.WriteLine("Enter car info first!");

            }
        
    }
}

public class ExitCommand : Command
{
    public void Execute()
    {
        Environment.Exit(0);
    }
}

public class EnterInfoCommand : Command
{
    public void Execute()
    {
        car.PopulateBrandList();
        car.PopulateModelList();
        car.PopulateQuantityList();
        car.PopulateCostList();
    }
}