// receiver class. 
public class Car
{
    // implementation of singleton design pattern
    private static Car instance;
    public static List<string> brands;
    public static List<string> model;
    public static List<int> quantity;
    public static List<int> cost;

    private Car()
    {
        brands = new List<string>();
        model = new List<string>();
        quantity = new List<int>();
        cost = new List<int>();
    }

    public static Car GetInstance()
    {
        if (Car.instance == null)
        {
            return new Car();
        }
        return Car.instance;
    }

    public void PopulateBrandList()
    {
        Console.Write("Enter car BRAND Name: ");
        string? brandName = Console.ReadLine();
        if (!brands.Contains(brandName))
        {
            brands.Add(brandName);
        }
    }

    public void PopulateModelList()
    {
        Console.Write("Enter car Model Name: ");
        string? modelName = Console.ReadLine();
        while(model.Contains(modelName)) {
            Console.WriteLine("This car model already exists. Enter a different model name: ");
            modelName = Console.ReadLine();
        }
        model.Add(modelName);
    }

    public void PopulateQuantityList()
    {
        int res;
        string? carQuantity;
        Console.Write("Enter car quantity: ");
        carQuantity = Console.ReadLine();
        while(!int.TryParse(carQuantity, out res)) {
            Console.WriteLine("Invalid format. Enter an integer: ");
            carQuantity = Console.ReadLine();
        }
            quantity.Add(res);
    }

    public void PopulateCostList()
    {
        int result;
        Console.Write("Enter car price: ");
        string? carPrice = Console.ReadLine();
        while(!int.TryParse(carPrice, out result)) {
            Console.WriteLine("Invalid format. Enter an integer: ");
            carPrice = Console.ReadLine();
        }
        cost.Add(result);
    }

    public int CountCars()
    {
        int sum = 0;
        foreach (var count in Car.quantity)
        {
            sum = sum + count;
        }
        return sum;
    }
    public int CountAveragePrice()
    {
        int sum = 0;
        foreach (var count in Car.cost)
        {
            sum = sum + count;
        }
        int average = sum / this.CountCars();
        return average;
    }
}