using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal abstract class Employee : User, IWorkScheduler
    {
        private EmployeeStatus _status;
        public string EmployeeId { get; private set; }
        public DateTime HireDate { get; private set; }

        public EmployeeStatus Status => _status;

        protected Employee(string EmployeeId, string login, string passwordHash, string firstName, string lastName, EmployeeStatus status)
            : base(login, passwordHash, firstName, lastName)
        {
            if (string.IsNullOrEmpty(EmployeeId))
            {
                throw new ArgumentException("Employee ID cannot be null or empty.", nameof(EmployeeId));
            }
            this.EmployeeId = EmployeeId;
            HireDate = DateTime.Now;
            _status = status;
        }

        public void GoOnVacation()
        {
            if (_status == EmployeeStatus.OnVacation)
            {
                throw new InvalidOperationException("Employee is already on vacation.");
            }
            _status = EmployeeStatus.OnVacation;
        }

        public void ReturnFromVacation()
        {
            if (_status != EmployeeStatus.OnVacation)
            {
                throw new InvalidOperationException("Employee is not on vacation.");
            }
            _status = EmployeeStatus.Active;
        }
        public void TerminateEmployment()
        {
            if (_status == EmployeeStatus.Terminated)
            {
                throw new InvalidOperationException("Employee is already terminated.");
            }
            _status = EmployeeStatus.Terminated;
        }

    }
}
