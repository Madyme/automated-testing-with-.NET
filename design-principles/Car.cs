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
        model.Add(Console.ReadLine());
    }

    public void PopulateQuantityList()
    {
        Console.Write("Enter car quantity: ");
        quantity.Add(Convert.ToInt32(Console.ReadLine()));
    }

    public void PopulateCostList()
    {
        Console.Write("Enter car price: ");
        cost.Add(Convert.ToInt32(Console.ReadLine()));
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