using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

public class Boat
{
    public void Destination(string destination)
    {
        Console.WriteLine($"Boat Destenation: {destination}");
    }
}