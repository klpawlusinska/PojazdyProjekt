namespace PojazdyProjekt;

public class Boat : Vehicle, ISailable
{
    public Boat(string name, string manufacturer, int maxSpeed, int passengerCount, string driveType)
        : base(name, manufacturer, maxSpeed, passengerCount, driveType)
    {
    }

    public override string VehicleType => "lodz";
}
