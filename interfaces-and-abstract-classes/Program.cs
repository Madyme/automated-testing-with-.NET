// Bird bird = new Bird(new Coordinate(4, 5, 6), new Coordinate(0, 0, 0));
// bird.FlyTo(bird.FlyToPoint);
// Console.WriteLine(bird.FlyTo(bird.FlyToPoint));
// var birdFlyToCoordinate = bird.FlyTo(bird.FlyToPoint);
// var birdCurrentCoordinate = bird.GetCurrentPosition(bird.CurrentPoint);
// Console.WriteLine(bird.GetDistance(birdFlyToCoordinate, birdCurrentCoordinate));
// double distance = bird.GetDistance(birdFlyToCoordinate, birdCurrentCoordinate);
// Console.WriteLine(bird.GetFlyTime(distance));

// Plane plane = new Plane(new Coordinate(4, 5, 6), new Coordinate(200, 500, 600));
// var planeFlyToCoordinate = plane.FlyTo(plane.FlyToPoint);
// var planeCurrentCoordinate = plane.GetCurrentPosition(plane.CurrentPoint);
// double distance = plane.GetDistance(planeFlyToCoordinate, planeCurrentCoordinate);
// Console.WriteLine(plane.GetFlyTime(distance));

// Drone drone = new Drone(new Coordinate(4, 5, 6), new Coordinate(200, 500, 600));
// var droneFlyToCoordinate = drone.FlyTo(drone.FlyToPoint);
// var droneCurrentCoordinate = drone.GetCurrentPosition(drone.CurrentPoint);
// double distance = drone.GetDistance(droneFlyToCoordinate, droneCurrentCoordinate);
// Console.WriteLine(drone.GetFlyTime(distance));


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

