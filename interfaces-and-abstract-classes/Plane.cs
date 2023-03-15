public class Plane : IFlyable
{
    public Coordinate CurrentPoint { get; set; }
    public Coordinate FlyToPoint { get; set; }

    public double InitialSpeed { get; } = 200;

    public double IncreasedSpeed { get; } = 10;

    public Coordinate FlyTo(Coordinate newPoint2)
    { // define fly-to point
        return new Coordinate(newPoint2.xCoordinate, newPoint2.yCoordinate, newPoint2.zCoordinate);
    }

    public Coordinate GetCurrentPosition(Coordinate newPoint)
    { // define current position
        return new Coordinate(newPoint.xCoordinate, newPoint.yCoordinate, newPoint.zCoordinate);
    }

    public double GetDistance(Coordinate flyToPoint, Coordinate currentPoint)
    { // calculate distance between current position and fly-to position
        return Math.Sqrt(Math.Pow((flyToPoint.xCoordinate - currentPoint.xCoordinate), 2) + Math.Pow((flyToPoint.yCoordinate - currentPoint.yCoordinate), 2) + Math.Pow((flyToPoint.zCoordinate - currentPoint.zCoordinate), 2));
    }

    public double GetAvgSpeed(double distance)
    {
        double speedRangeLength = Math.Floor(distance / 10); // aircraft increases speed by 10 km/h every 10 km of flight. Calculate how many times plane will increase its speed
        List<double> speedRange = new List<double>() { this.InitialSpeed };
        for (int i = 1; i < speedRangeLength; i++)
        { // store increased speed values on every 10 km in the list
            speedRange.Add(speedRange[i - 1] + this.IncreasedSpeed);
        }
        double sumSpeed = 0;
        for (int i = 0; i < speedRange.Count; i++)
        {
            sumSpeed = sumSpeed + speedRange[i];
        }
        double avgSpeed = sumSpeed / speedRangeLength; // find average speed during the flight
        return avgSpeed;
    }

    public double GetFlyTime(double distance)
    {
        return distance / this.GetAvgSpeed(distance);
    }

    public Plane(Coordinate flyToPoint, Coordinate currentPoint)
    {
        this.CurrentPoint = currentPoint;
        this.FlyToPoint = flyToPoint;
    }
}