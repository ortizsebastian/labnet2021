using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp3.Entities;

namespace tp3.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public List<Employees> GetAll() => context.Employees.ToList();

        public void Add(Employees employees)
        {
            context.Employees.Add(employees);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var deleteEmployees = context.Employees.Single(e => e.EmployeeID == int.Parse(id));
            context.Employees.Remove(deleteEmployees);
            context.SaveChanges();
        }

        public void Update(Employees employees)
        {
            var employeesUpdate = context.Employees.Find(employees.EmployeeID);
            employeesUpdate.Address = employees.Address;
            context.SaveChanges();
        }
    }
}
