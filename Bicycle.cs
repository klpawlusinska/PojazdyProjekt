namespace PojazdyProjekt;

public class Bicycle : Vehicle, IDrivable
{
    public Bicycle(string name, string manufacturer, int maxSpeed, int passengerCount, string driveType)
        : base(name, manufacturer, maxSpeed, passengerCount, driveType)
    {
    }

    public override string VehicleType => "rower";
}
