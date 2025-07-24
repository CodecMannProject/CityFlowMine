using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Mechanic : Employee
    {
        public Mechanic(string EmployeeId, string login, string passwordHash, string firstName, string lastName, EmployeeStatus status) : base(EmployeeId, login, passwordHash, firstName, lastName, status)
        {
        }
        public override string GetRoleDescription() => "Mechanic: Responsible for the maintenance and repair of buses, ensuring they are safe and operational.";
    }
}
