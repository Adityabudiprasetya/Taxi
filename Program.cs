using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class program
    {
        static void Main(string[] args)
        {


            Taxi taxi = new Taxi();
            Taxi taxi1 = new Taxi();

            taxi.drivername = "Barzy";
            taxi.onduty = true;
            taxi.numpass = 64579;

            taxi1.drivername = "Aril";
            taxi1.onduty = true;
            taxi1.numpass = 465987;

            taxi.info();
            taxi.ongoing();
            taxi.done();

            taxi1.info();
            taxi1.ongoing();
            taxi1.done();

            Console.ReadKey();
        }
    }
}