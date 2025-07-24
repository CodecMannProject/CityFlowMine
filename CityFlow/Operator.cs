using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Operator : Employee
    {
        public Operator(string EmployeeId, string login, string passwordHash, string firstName, string lastName, EmployeeStatus status) : base(EmployeeId, login, passwordHash, firstName, lastName, status)
        {
        }
        public override string GetRoleDescription() => "Operator: Monitors and manages the bus fleet, ensuring efficient operations and safety compliance.";
    }
}
