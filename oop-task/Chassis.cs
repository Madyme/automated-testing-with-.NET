public class Chassis 
{
    public int NumberOfWheels {get; set;} = 4;
    public string? Num {get; set;}
    public int PermissibleLoad {get; set;}

    public void GetChassisInfo() {
        Console.Write("Enter number of chassis: ");
        this.Num = Console.ReadLine();
        Console.Write("What is permissible load of chassis: ");
        this.PermissibleLoad = Convert.ToInt32(Console.ReadLine());
    } 
    
    public void DisplayChassisInfo()
    {
        Console.WriteLine($"there are {NumberOfWheels} wheels, \n {Num}, \n {PermissibleLoad} in that chassis");
    }
}