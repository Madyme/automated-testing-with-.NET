class Drone : IFlyable {
    public Coordinate CurrentPoint {get; set;}
    public Coordinate FlyToPoint {get; set;}

    public Drone(Coordinate flyToPoint, Coordinate currentPoint) {
        this.FlyToPoint = flyToPoint;
        this.CurrentPoint = currentPoint;
    }

    public Random? constantSpeed; //randomly generate constant speed of drone

    public Coordinate FlyTo(Coordinate newPoint2) { // define fly-to point
        return new Coordinate(newPoint2.xCoordinate, newPoint2.yCoordinate, newPoint2.zCoordinate);
    }

    public Coordinate GetCurrentPosition(Coordinate newPoint) { // define current position
        return new Coordinate(newPoint.xCoordinate, newPoint.yCoordinate, newPoint.zCoordinate);
    }

    public double GetDistance(Coordinate flyToPoint, Coordinate currentPoint) { // calculate distance between current position and fly-to position
        return Math.Sqrt(Math.Pow((flyToPoint.xCoordinate - currentPoint.xCoordinate), 2) + Math.Pow((flyToPoint.yCoordinate - currentPoint.yCoordinate), 2) + Math.Pow((flyToPoint.zCoordinate - currentPoint.zCoordinate), 2));
    }

    public double GetFlyTime(double distance) {
        //1. get overall flight time in minutes not considering hover time: t = distance / this.ConstantSpeed * 60;
        //2. he drone hovering in the air every 10 minutes flight for 1 minute => 
        // define number of time time intervals: numberOfTimeIntervals = t / 10;
        //3. add hover time (1 minute) on each time interval to overall flight time: numberOfTimeIntervals * 1 => numberOfTimeIntervals;
        //4. overall flightTime = t + numberOfTimeIntervals => distance / this.ConstantSpeed * 60 + distance / this.ConstantSpeed * 60 / 10 =>
        // distance / this.ConstantSpeed * 60 + distance / this.ConstantSpeed * 6 = distance / this.ConstantSpeed * 66;
        this.constantSpeed = new Random();
        return distance / this.constantSpeed.Next(1, 50) * 66;
    }
}