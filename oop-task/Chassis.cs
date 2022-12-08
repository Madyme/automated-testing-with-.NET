// number of wheels, number, permissible load

class Chassis {
    int numberOfWheels = 4;
    string num = "";
    int permissibleLoad = 1;

    public int NumberOfWheels {get; set;}
    public string Num {get; set;}
    public int PermissibleLoad {get; set;}

    public Chassis(int numberOfWheels, string num, int permissibleLoad) {
        NumberOfWheels = numberOfWheels; Num = num; PermissibleLoad = permissibleLoad;
    }
}