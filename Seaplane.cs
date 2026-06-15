namespace PojazdyProjekt;

public class Seaplane : Vehicle, IFlyable, ISailable
{
    public Seaplane(string name, string manufacturer, int maxSpeed, int passengerCount, string driveType)
        : base(name, manufacturer, maxSpeed, passengerCount, driveType)
    {
    }

    public override string VehicleType => "wodolot";
}
