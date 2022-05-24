using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

public class Helicopter : IFlyingTransport
{
    Logger logger = new();

    public void Fly(string origin, string destination, int passengers)
    {
        logger.Message($"Helicopter Depart: {origin} | Arrive: {destination} | Total passengers: {passengers}");
    }
}