class Bird : IFlyable {

    public Coordinate CurrentPoint {get; set;}
    public Coordinate FlyToPoint {get; set;}
    public Random? speed ; //constant speed of bird (generated randomly)

    public Bird(Coordinate flyToPoint, Coordinate currentPoint) {
        this.CurrentPoint = currentPoint;
        this.FlyToPoint = flyToPoint;
        
    }

    public Coordinate FlyTo(Coordinate newPoint2) { // define fly-to position
        return new Coordinate(newPoint2.xCoordinate, newPoint2.yCoordinate, newPoint2.zCoordinate);
    }

    public Coordinate GetCurrentPosition(Coordinate newPoint) { //define current position
        return new Coordinate(newPoint.xCoordinate, newPoint.yCoordinate, newPoint.zCoordinate);
    }
    
    public double GetDistance(Coordinate flyToPoint, Coordinate currentPoint) { // calculate distance between current position and fly-to position
        return Math.Sqrt(Math.Pow((flyToPoint.xCoordinate - currentPoint.xCoordinate), 2) + Math.Pow((flyToPoint.yCoordinate - currentPoint.yCoordinate), 2) + Math.Pow((flyToPoint.zCoordinate - currentPoint.zCoordinate), 2));
    }

    public double GetFlyTime(double distance) { // calculate flight
        this.speed = new Random();
        return distance / this.speed.Next(0, 21); 
    }


}