class Scooter : Vehicle {
    public bool HasSeat {get; set;}

    public Scooter(bool hasSeat, int engPower, int engVolume, string type,
               string engSerialNum, string transmType) 
               : base(engPower, engVolume, type, engSerialNum, transmType) {

                    HasSeat = hasSeat;                 
               }
}