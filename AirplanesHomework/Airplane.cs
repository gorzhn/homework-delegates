using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesHomework
{
    // maybe something more restrictive ?
    public class Airplane
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Airplane(string name, int capacity) {
            this.Name = name;
            this.Capacity = capacity;
        }

    }
}

