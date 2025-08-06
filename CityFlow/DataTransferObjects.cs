using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal class DataTransferObjects
    {
        public class AdministratorData
        {
            public string EmployeeId { get; set; }
            public string Login { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class OperatorData
        {
            public string EmployeeId { get; set; }
            public string Login { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}