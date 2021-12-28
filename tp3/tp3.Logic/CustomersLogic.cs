using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp3.Data;
using tp3.Entities;

namespace tp3.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public List<Customers> GetAll() => context.Customers.ToList();

        public void Add(Customers newCustomer)
        {
            context.Customers.Add(newCustomer);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var deleteCustomer = context.Customers.Single(c => c.CustomerID == id);
            context.Customers.Remove(deleteCustomer);
            context.SaveChanges();
        }

        public void Update(Customers customers)
        {
            var customersUpdate = context.Customers.Find(customers.CustomerID);
            customersUpdate.Address = customers.Address;
            context.SaveChanges();
        }
    }
}
