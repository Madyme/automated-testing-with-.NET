Execute();

Coordinate CreateCoordinate()
{
    Console.Write("Enter positive x coordinate: ");
    int xCoordinate = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter positive y coordinate: ");
    int yCoordinate = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter positive z coordinate: ");
    int zCoordinate = Convert.ToInt32(Console.ReadLine());
    return new Coordinate(xCoordinate, yCoordinate, zCoordinate);
}

void Execute()
{
    Console.WriteLine("1. Bird\n" +
                      "2. Plane\n" +
                      "3. Drone");
    Console.Write("Enter an option you would like to get info about: ");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Console.WriteLine("Enter coordinates for fly-to position, and for current position of BIRD: ");
            Bird bird = new Bird(CreateCoordinate(), CreateCoordinate());

            var birdFlyToCoordinate = bird.FlyTo(bird.FlyToPoint);
            var birdCurrentCoordinate = bird.GetCurrentPosition(bird.CurrentPoint);
            double birdDistance = bird.GetDistance(birdFlyToCoordinate, birdCurrentCoordinate);
            Console.WriteLine($"the overall flight time of the bird: {bird.GetFlyTime(birdDistance)} hours");
            break;
        case 2:
            Console.WriteLine("Enter coordinates for fly-to position, and for current position of PLANE: ");
            Plane plane = new Plane(CreateCoordinate(), CreateCoordinate());
            var planeFlyToCoordinate = plane.FlyTo(plane.FlyToPoint);
            var planeCurrentCoordinate = plane.GetCurrentPosition(plane.CurrentPoint);
            double planeDistance = plane.GetDistance(planeFlyToCoordinate, planeCurrentCoordinate);
            Console.WriteLine($"the overall flight time of the plane: {plane.GetFlyTime(planeDistance)} hours");
            break;
        case 3:
            read:
            Console.WriteLine("Enter coordinates for fly-to position, and for current position of DRONE: ");
            Drone drone = new Drone(CreateCoordinate(), CreateCoordinate());
            var droneFlyToCoordinate = drone.FlyTo(drone.FlyToPoint);
            var droneCurrentCoordinate = drone.GetCurrentPosition(drone.CurrentPoint);
            while (drone.GetDistance(droneFlyToCoordinate, droneCurrentCoordinate) > 1000) // restriction for drone
            {
                Console.WriteLine("a drone cannot fly at a distance of more than 1000 km. Please, enter valid coordinates.");
                goto read;
            }
            double droneDistance = drone.GetDistance(droneFlyToCoordinate, droneCurrentCoordinate);
            Console.WriteLine($"the overall flight time of the drone: {drone.GetFlyTime(droneDistance)} minutes");
            break;

    }
}
