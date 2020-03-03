using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesHomework
{
    class Monitor
    {
        public static void TakeOff(object source, Airplane a) {
            Console.WriteLine("The airplane " + a.Name + " just tookoff");
        }
        public static void Arrival(object source, Airplane a) {
            Console.WriteLine("The airplane " + a.Name + " has arrived");
        }

        public static void Delay(int minutes, Airplane a) {
            Console.WriteLine("The airplane " + a.Name + " has been delayed by " + minutes + " minutes" );

                        
        }
    }
}
