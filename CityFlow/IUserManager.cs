using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    internal interface IUserManager
    {
        void ResetPasswordFor(Employee targetEmployee, string newTemporaryPassword);

        void BlockAccount(Employee targetEmployee);

        void UnblockAccount(Employee targetEmployee);
    }
}
