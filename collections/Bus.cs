class Bus : Vehicle {

    int numberOfSeats;
    public int NumberOfSeats {

        set {
            if(numberOfSeats < 36) {
                Console.WriteLine("Minimal Number of seats is 36");
            } else {
                numberOfSeats = value;
            }
        }

        get {
            return numberOfSeats;
        }
    }

    public Bus(int seatsNum, int engPower, int engVolume, string type,
               string engSerialNum, string transmType) 
               : base(engPower, engVolume, type, engSerialNum, transmType) {

                 NumberOfSeats = seatsNum;
    }
}