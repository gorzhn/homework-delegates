using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport air = new Airport("Skopski Aerodrom");
            User u = new User("Gorjan");
            Airplane ar = new Airplane("Boeing 747", 200);
            Airplane ar2 = new Airplane("Boeing 757", 200);
            Airplane ar3 = new Airplane("Boeing 767", 200);
            Airplane ar4 = new Airplane("Boeing 777", 200);
            Airplane ar5 = new Airplane("Boeing 787", 200);



            air.OnDelay += u.InformUserPlaneDelay;
            air.OnTakeoff += u.InformUserPlaneTakeoff;
            air.Incoming(ar);
            u.ListPlanes(air);
            air.Outgoing(ar);
            air.Delay(ar, 15);
            air.Incoming(ar2);
            air.Outgoing(ar2);
            air.Incoming(ar3);
            air.Outgoing(ar3);
            air.ListPlanes();




            Console.ReadKey();
            
        }
    }
}
