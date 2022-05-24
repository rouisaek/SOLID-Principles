using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

public class Airport
{
    IFlyingTransport _vehicle;

    public Airport(IFlyingTransport vehicle)
    {
        _vehicle = vehicle;
    }

    public void SetFly(string origin, string destination, int passengers)
    {
        _vehicle.Fly(origin, destination, passengers);
    }
}