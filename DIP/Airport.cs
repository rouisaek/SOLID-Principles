using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

public class Airport
{
    IFlyingTransport _transport;

    public Airport(IFlyingTransport transport)
    {
        _transport = transport;
    }

    public void PrintDestination(string destenation)
    {
        _transport.Destination(destenation);
    }
}