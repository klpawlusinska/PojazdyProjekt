namespace PojazdyProjekt;

public abstract class Vehicle
{
    protected Vehicle(string name, string manufacturer, int maxSpeed, int passengerCount, string driveType)
    {
        Name = name;
        Manufacturer = manufacturer;
        MaxSpeed = maxSpeed;
        PassengerCount = passengerCount;
        DriveType = driveType;
    }

    public string Name { get; }
    public string Manufacturer { get; }
    public int MaxSpeed { get; }
    public int PassengerCount { get; }
    public string DriveType { get; }

    public abstract string VehicleType { get; }

    public override string ToString()
    {
        string text = $"Nazwa: {Name}\n";
        text += $"Producent: {Manufacturer}\n";
        text += $"Typ pojazdu: {VehicleType}\n";
        text += $"Maksymalna predkosc: {MaxSpeed} km/h\n";
        text += $"Liczba pasazerow: {PassengerCount}\n";
        text += $"Typ napedu: {DriveType}\n";
        text += "Mozliwosci:\n";

        foreach (string capability in GetCapabilities())
        {
            text += $"- {capability}\n";
        }

        return text;
    }

    public virtual List<string> GetCapabilities()
    {
        List<string> capabilities = new List<string>();

        if (this is IDrivable)
        {
            capabilities.Add("jezdzi po ladzie");
        }

        if (this is IFlyable)
        {
            capabilities.Add("lata");
        }

        if (this is ISailable)
        {
            capabilities.Add("plywa");
        }

        return capabilities;
    }
}
