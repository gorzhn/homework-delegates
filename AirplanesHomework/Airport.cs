using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesHomework
{
    public class Airport
    {
        public delegate void TakeOffDelegate(object source, Airplane e);
        public event TakeOffDelegate OnTakeoff;
        public event EventHandler<Airplane> OnArrival;
        public delegate void DelayDelegate(int minutes, Airplane e);
        public event DelayDelegate OnDelay;

        public List<Airplane> Airplanes;
        public string Name { get; set; }

        public void Incoming(Airplane airplane) {
            Airplanes.Add(airplane);
            OnArrival?.Invoke(this, airplane);
        }
        public void Outgoing(Airplane airplane) {
            Airplanes.Remove(airplane);
            OnTakeoff?.Invoke(this, airplane);
        }

        public void Delay(Airplane airplane, int minutes) {
            OnDelay?.Invoke(minutes, airplane);
        }

        public Airport( string Name) {
            this.Name = Name;
            OnTakeoff += Monitor.TakeOff;
            OnArrival += Monitor.Arrival;
            OnDelay += Monitor.Delay;
            Airplanes = new List<Airplane>();
        }
    }
}
