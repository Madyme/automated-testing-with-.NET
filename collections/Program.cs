using System.Collections;

var vehicleList = new List<object> {
    new Car{
            Name = "Santa fe", BrandName = "Hundai",
            EnginePower = 191, EngineVolume = 5, Type = "electric",
            EngineSerialNum = "AS0903", TransmisType = "automatic"
            },

    new Car{ 
            Name = "Spark", BrandName = "Chevrolet",
            EnginePower = 30, EngineVolume = 2,
            Type = "internal combustion", EngineSerialNum = "PJ3083",
            TransmisType = "manual"
            },
    new Car{ 
            Name = "Land Cruiser", BrandName = "Toyota", 
            EnginePower = 344, EngineVolume = 7, 
            Type = "internal combustion", EngineSerialNum = "PJ3422", 
            TransmisType = "automatic"
            },
    new Truck { 
            TrailerType = "curtainside", EnginePower = 50, 
            EngineVolume = 16, Type = "internal combustion", 
            EngineSerialNum = "BA2332", TransmisType = "manual"
            },
    new Truck{ 
            TrailerType = "refrigirated", EnginePower = 323, 
            EngineVolume = 35, Type = "internal combustion", 
            EngineSerialNum = "KG9384", TransmisType = "manual"
            },
    new Truck{ 
            TrailerType = "drop-deck", EnginePower = 200, 
            EngineVolume = 10, Type = "internal combustion", 
            EngineSerialNum = "LS5454", TransmisType = "manual"
            },
    new Bus{ 
            NumberOfSeats = 56, EnginePower = 44, EngineVolume = 29, 
            Type = "electric", EngineSerialNum = "PS0923", 
            TransmisType = "manual"
            },
    new Bus{ 
            NumberOfSeats = 39, EnginePower = 40, 
            EngineVolume = 13, Type = "internal combustion", 
            EngineSerialNum = "LA0909", TransmisType = "manual"
            },
    new Bus{ 
            NumberOfSeats = 36, EnginePower = 25, 
            EngineVolume = 14, Type = "electric", 
            EngineSerialNum = "DJ2937", TransmisType = "manual"
            },
    new Scooter{ 
            HasSeat = false, EnginePower = 22, 
            EngineVolume = 4, Type = "electric", 
            EngineSerialNum = "KS2836", TransmisType = "cvt"
            },
    new Scooter{ 
            HasSeat = true, EnginePower = 20, 
            EngineVolume = 4, Type = "brushed", 
            EngineSerialNum = "MD6757", TransmisType = "cvt"
            },
    new Scooter{ 
            HasSeat = true, EnginePower = 10, 
            EngineVolume = 3, Type = "electric", 
            EngineSerialNum = "SD7657", TransmisType = "cvt"
            }

};

void GetAutoByParameter(string param, string value)
{
    foreach (var vehicle in vehicleList)
    {
        if (vehicle.GetType().GetProperty(param) == null)
        {
            throw new GetAutoByParameterException("This property does not exist");
        }
        else if (value.Equals(vehicle.GetType().GetProperty(param).GetValue(vehicle)))
        {
            Console.WriteLine("Found a match :) ");
            break;
        }
    }
}

void RemoveAuto(string engineSerialNum)
{
    bool found = false;
    for (int i = 0; i < vehicleList?.Count; i++)
    {
        if (engineSerialNum.Equals(vehicleList[i]?.GetType()?.GetProperty("EngineSerialNum")?.GetValue(vehicleList[i])))
        {
            vehicleList.Remove(vehicleList[i]);
            found = true;
        }
    }
    if (found == false)
    {
        throw new RemoveAutoException("This engine serial number does not exist");
    }
}

void UpdateAuto(string engineSerialNum)
{
    bool found = false;
    for (int i = 0; i < vehicleList?.Count; i++)
    {
        var propInfo = vehicleList[i].GetType().GetProperty("EngineSerialNum");
        if (engineSerialNum.Equals(propInfo?.GetValue(vehicleList[i])))
        {
            Console.Write("Enter new Engine Serial Number: ");
            string? newEngineSerialNum = Console.ReadLine();
            propInfo.SetValue(vehicleList[i], Convert.ChangeType(newEngineSerialNum, propInfo.PropertyType), null);
            Console.WriteLine($"updated to {propInfo.GetValue(vehicleList[i])}");
            found = true;
            break;
        }
    }
    if (found == false)
    {
        throw new UpdateAutoException("This engine serial number does not exist");
    }

}
// GetAutoByParameter("NonExistingProp", "value");
// RemoveAuto("PJ3422");
// UpdateAuto("PJ3422");