using DIP;

Airplane airplane = new();
Helicopter helicopter = new();
Boat boat = new();

Airport airport = new(airplane);
airport.PrintDestination("New York");

Console.ReadKey();