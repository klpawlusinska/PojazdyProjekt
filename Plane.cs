namespace PojazdyProjekt;

public class Plane : Vehicle, IFlyable
{
    public Plane(string name, string manufacturer, int maxSpeed, int passengerCount, string driveType)
        : base(name, manufacturer, maxSpeed, passengerCount, driveType)
    {
    }

    public override string VehicleType => "samolot";
}
