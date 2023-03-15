public struct Coordinate
{
    public double xCoordinate;
    public double yCoordinate;
    public double zCoordinate;

    public Coordinate(double xCoordinate, double yCoordinate, double zCoordinate)
    {
        if (xCoordinate < 0 || 
            yCoordinate < 0 || 
            zCoordinate < 0)
        {
            Console.WriteLine("Invalid parameter");
        }
        else
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.zCoordinate = zCoordinate;
        }
    }

    public void PrintCoordinate()
    {
        Console.WriteLine($"x is {xCoordinate};\ny is {yCoordinate};\nz is {zCoordinate}");
    }
}

interface IFlyable
{
    Coordinate FlyTo(Coordinate newPoint);
    double GetFlyTime(double distance);
}
