using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP;

public interface IFlyingTransport
{
    public void Fly(string origin, string destination, int passengers);
}