Hierarchia klas - Pojazdy


Struktura projektu

Projekt sklada sie z kilku plikow:
`Program.cs` - glowny plik programu, tworzy liste pojazdow i wypisuje je w konsoli.
`Vehicle.cs` - abstrakcyjna klasa bazowa dla wszystkich pojazdow. Zawiera wspolne dane, takie jak nazwa, producent, maksymalna predkosc, liczba pasazerow i typ napedu.
`Car.cs` - klasa samochodu.
`Bicycle.cs` - klasa roweru.
`Plane.cs` - klasa samolotu.
`Boat.cs` - klasa lodzi.
`Seaplane.cs` - klasa wodnosamolotu, czyli pojazdu, ktory lata i plywa.
`IDrivable.cs`, `IFlyable.cs`, `ISailable.cs` - interfejsy opisujace mozliwosci pojazdow.

Jak dzialaja interfejsy?

Interfejsy sa tutaj uzyte jako oznaczenia mozliwosci.
Na przyklad:
`Car : Vehicle, IDrivable` oznacza, ze samochod jest pojazdem i potrafi jezdzic.
`Plane : Vehicle, IFlyable` oznacza, ze samolot jest pojazdem i potrafi latac.
`Seaplane : Vehicle, IFlyable, ISailable` oznacza, ze wodnosamolot jest pojazdem, ktory lata i plywa.
Dzieki temu metoda `GetCapabilities()` w klasie `Vehicle` sama sprawdza, jakie interfejsy ma dany pojazd, i automatycznie wypisuje jego mozliwosci.

Jak uruchomic?
Na stronie repozytorium kliknij zielony przycisk Code → Download ZIP 
Rozpakuj pobrany plik ZIP gdzieś na dysku (np. na Pulpicie) 
Wejdź do rozpakowanego folderu i kliknij dwukrotnie na plik AplikacjaBankowa.slnx — otworzy się automatycznie w Visual Studio 2022 
W Visual Studio naciśnij Ctrl+Shift+B żeby skompilować projekt (po polsku: Kompiluj → Kompiluj rozwiązanie) 
Jeśli nie ma błędów, naciśnij F5 albo zielony przycisk ▶️ żeby uruchomić

Co jest zaimplementowane?
- klasa abstrakcyjna `Vehicle`,
- dziedziczenie po klasie `Vehicle`,
- interfejsy `IDrivable`, `IFlyable`, `ISailable`,
- polimorfizm przez liste `List<Vehicle>`,
- nadpisana metoda `ToString()`,
- automatyczne wypisywanie mozliwosci pojazdu na podstawie interfejsow,
- kilka typow pojazdow, w tym pojazd mieszany `Seaplane`.

Przykladowy wynik
Program wypisuje dane pojazdu w takim stylu:
```text
Nazwa: Wodnosamolot
Producent: Cessna
Typ pojazdu: wodnosamolot
Maksymalna predkosc: 300 km/h
Liczba pasazerow: 6
Typ napedu: silnik smiglowy
Mozliwosci:
- lata
- plywa
```

Technologie
C#
.NET 8
Visual Studio
Aplikacja konsolowa
