using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class PublicTransport
    {
        public int Passengers { get; set; }
        public string TradeMark { get; set; }
        public bool State { get; set; }

        protected PublicTransport(int passengers, string tradeMark)
        {
            Passengers = passengers;
            TradeMark = tradeMark;
            State = true;
        }
        protected abstract void Move();
        protected abstract void Stop();
    }
}
