Bird bird = new Bird(new Coordinate(4, 5, 6), new Coordinate(0, 0, 0));
// bird.FlyTo(bird.FlyToPoint);
// Console.WriteLine(bird.FlyTo(bird.FlyToPoint));
var birdFlyToCoordinate = bird.FlyTo(bird.FlyToPoint);
var birdCurrentCoordinate = bird.GetCurrentPosition(bird.CurrentPoint);
Console.WriteLine(bird.GetDistance(birdFlyToCoordinate, birdCurrentCoordinate));
double distance = bird.GetDistance(birdFlyToCoordinate, birdCurrentCoordinate);
Console.WriteLine(bird.GetFlyTime(distance));
struct Coordinate {

    public double xCoordinate;
    public double yCoordinate;
    public double zCoordinate;
    
    public Coordinate(double xCoordinate, double yCoordinate, double zCoordinate) {
        if(xCoordinate < 0 || yCoordinate < 0 || zCoordinate < 0) {
            Console.WriteLine("Invalid parameter");
        } else {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.zCoordinate = zCoordinate;
        }
    }

    public void PrintCoordinate() {
        Console.WriteLine($"x is {xCoordinate};\ny is {yCoordinate};\nz is {zCoordinate}");
    }
}

interface IFlyable {
    Coordinate FlyTo(Coordinate newPoint) ;
    double GetFlyTime(double distance);
}

class Bird : IFlyable {

    public Coordinate CurrentPoint {get; set;}
    public Coordinate FlyToPoint {get; set;}
    public double Speed {get; set;} = 20;

    public Bird(Coordinate flyToPoint, Coordinate currentPoint) {
        CurrentPoint = currentPoint;
        FlyToPoint = flyToPoint;
        
    }

    public Coordinate FlyTo(Coordinate newPoint2) {
        // Console.WriteLine($"this is {newPoint2.xCoordinate}, {newPoint2.yCoordinate}, {newPoint2.zCoordinate} flyTo position");
        return new Coordinate(newPoint2.xCoordinate, newPoint2.yCoordinate, newPoint2.zCoordinate);
    }

    public Coordinate GetCurrentPosition(Coordinate newPoint) {
        // Console.WriteLine($"this is {newPoint.xCoordinate} current position");
        return new Coordinate(newPoint.xCoordinate, newPoint.yCoordinate, newPoint.zCoordinate);
    }
    
    public double GetDistance(Coordinate flyToPoint, Coordinate currentPoint) {
        return Math.Sqrt(Math.Pow((flyToPoint.xCoordinate - currentPoint.xCoordinate), 2) + Math.Pow((flyToPoint.yCoordinate - currentPoint.yCoordinate), 2) + Math.Pow((flyToPoint.zCoordinate - currentPoint.zCoordinate), 2));
    }

    public double GetFlyTime(double distance) {
        return distance / this.Speed;
    }


}