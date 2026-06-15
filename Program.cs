using PojazdyProjekt;

List<Vehicle> vehicles = new List<Vehicle>();

vehicles.Add(new Car("Toyota Corolla", "Toyota", 180, 5, "silnik spalinowy"));
vehicles.Add(new Bicycle("Rower gorski", "Kross", 40, 1, "naped miesniowy"));
vehicles.Add(new Plane("Boeing 737", "Boeing", 850, 180, "silniki odrzutowe"));
vehicles.Add(new Boat("Motorowka", "Yamaha", 90, 6, "silnik motorowy"));
vehicles.Add(new Seaplane("Wodnosamolot", "Cessna", 300, 6, "silnik smiglowy"));

foreach (Vehicle vehicle in vehicles)
{
    Console.WriteLine(vehicle);
    Console.WriteLine();
}
