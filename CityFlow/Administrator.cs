using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class Administrator : Employee, IUserManager
    {
        public Administrator(string EmployeeId, string login, string passwordHash, string firstName, string lastName, EmployeeStatus status) : base(EmployeeId, login, passwordHash, firstName, lastName, status)
        {
        }
        public override string GetRoleDescription()=> "Administrator: Manages the transport system, oversees operations, and ensures compliance with regulations.";

        public void ResetPasswordFor(User targetEmployee)
        {
            if (targetEmployee == null)
            {
                MessageBox.Show("User not found.");
                throw new ArgumentException("User not found.");
            }
            else
            {
                string temporaryPassword = Guid.NewGuid().ToString("N").Substring(0, 10); 
                targetEmployee.ChangePassword(targetEmployee.GetPasswordHash(), temporaryPassword);
            }
        }
    }
}
