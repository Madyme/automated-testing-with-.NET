// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Collections;

var vehicleList = new List<object>() {
    new Car("Spark", "Chevrolet", 30, 2, "internal combustion", "PJ3083", "manual"),
    new Car("Santa fe", "Hundai", 191, 5, "electric", "AS0903", "automatic"),
    new Car("Land Cruiser", "Toyota", 344, 7, "internal combustion", "PJ3422", "automatic"),
    new Truck("curtainside", 50, 16, "internal combustion", "BA2332", "manual"),
    new Truck("refrigirated", 323, 35, "internal combustion", "KG9384", "manual"), 
    new Truck("drop-deck", 200, 10, "internal combustion", "LS5454", "manual"),
    new Bus(56, 44, 29, "electric", "PS0923", "manual"), 
    new Bus(39, 40, 13, "internal combustion", "LA0909", "manual"),
    new Bus(35, 25, 14, "electric", "DJ2937", "manual"),
    new Scooter(false, 22, 4, "electric", "KS2836", "cvt"), 
    new Scooter(true, 20, 4, "brushed", "MD6757", "cvt"),
    new Scooter(true, 10, 3, "electric", "SD7657", "cvt")
};
