using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class SuperAdmin : Administrator
    {
        public SuperAdmin(string EmployeeId, string login, string passwordHash, string firstName, string lastName, EmployeeStatus status) : base(EmployeeId, login, passwordHash, firstName, lastName, status)
        {
        }
        public override string GetRoleDescription() => "SuperAdmin: Oversees all operations, manages system-wide settings, and has the highest level of access to the transport system.";

        public AdministratorData PreparePromotion(Employee employeeToPromotre )
        {
            if(employeeToPromotre.Status == EmployeeStatus.OnLeave)
            { 
                MessageBox.Show("Cannot promote an employee who is currently on leave.");
                throw new InvalidOperationException("Cannot promote an employee who is currently on leave.");
            }
            else
            {
                return new AdministratorData
                (
                    employeeToPromotre.EmployeeId,
                    employeeToPromotre.Login,
                    employeeToPromotre.GetPasswordHash(),
                    employeeToPromotre.FirstName
                );
            }
        }
        public class AdministratorData
        {
            public AdministratorData(string employeeId, string login, string firstName, string lastName)
            {
                EmployeeId = employeeId;
                Login = login;
                FirstName = firstName;
                LastName = lastName;
            }

            public string EmployeeId { get; set; }
            public string Login { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
