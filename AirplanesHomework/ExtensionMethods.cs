using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesHomework
{
    public static class ExtensionMethods
    {
        public static void ListPlanes(this object obj) {
            var airport = obj as Airport;
            foreach (Airplane a in airport.Airplanes) {
                Console.WriteLine(a.Name + " - " + a.Capacity + " is at " + airport.GetName());
            }
        }
      
        public static string GetName(this Airport airport) { 
        return airport.Name;
        }

        

    }
}
