using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T add);
        void Delete(string id);
        void Update(T update);
    }
}
