using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Logic
    {
        private List<Bus> BusList { get; set; } 
        private List<Cab> CabList { get; set; } 

        public Logic()
        {
            BusList = new List<Bus>();
            CabList = new List<Cab>();
        }

        //Agregar uno o dos metodos privados
        public void AddBus(Bus bus) => BusList.Add(bus);
        public void AddCab(Cab cab) => CabList.Add(cab);
        public List<Bus> GetBusList() => BusList;
        public List<Cab> GetCabList() => CabList;
    }
}
