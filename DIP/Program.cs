using DIP;

Airplane airplane = new();
Helicopter helicopter = new();
Boat boat = new();

Airport airport = new(airplane);
Airport airport1 = new(helicopter);

airport.SetFly("Canada", "USA", 324);
airport1.SetFly("New York", "LA", 10);

Console.ReadKey();