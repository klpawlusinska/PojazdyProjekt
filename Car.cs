namespace PojazdyProjekt;

public class Car : Vehicle, IDrivable
{
    public Car(string name, string manufacturer, int maxSpeed, int passengerCount, string driveType)
        : base(name, manufacturer, maxSpeed, passengerCount, driveType)
    {
    }

    public override string VehicleType => "samochod";
}
