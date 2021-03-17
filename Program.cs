using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugastaxi
{
    static class Program
    {
        static void Main(string[]args)
        {
            taxi taxi = new taxi();
            taxi.Drivername = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.taxiinfo();
            taxi.pickuppassenger();
            taxi.Dropoffpassenger();
            Console.Read();
        }

    }
}
