using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bus : PublicTransport
    {
        public Bus(int passengers, string tradeMark) : base(passengers, tradeMark) { }
        protected override void Move() => throw new NotImplementedException();
        protected override void Stop() => throw new NotImplementedException();
    }
}
