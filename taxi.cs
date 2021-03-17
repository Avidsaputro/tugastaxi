using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugastaxi
{
    class taxi
    {
        public string Drivername { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void taxiinfo()
        {
            Console.WriteLine("Driver name    : {0}", Drivername);
            Console.WriteLine("On Duty        : {0}", OnDuty);
            Console.WriteLine("Num Passenger  : {0}", NumPassenger);
        }
        public void pickuppassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang",Drivername);
        }
        public void Dropoffpassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang",Drivername);
        }

    }
}
