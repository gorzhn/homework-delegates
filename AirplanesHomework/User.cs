using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesHomework
{
    class User
    {
        public string name { get; set; }

        public User(string name) {
            this.name = name;
        }
        public void InformUserPlaneDelay(int minutes, Airplane airplane) {
            Console.WriteLine("Informing " + name + " that airplane " + airplane.Name + " has been delayed by " + minutes + " minutes");
        }
        public void InformUserPlaneTakeoff(object source, Airplane airplane)
        {
            Console.WriteLine("Informing " + name + " that airplane " + airplane.Name + " has tookoff");
        }

        public void ListPlanes(Airport airport) {
            airport.ListPlanes();
        }

        

    }
}
