using CityFlow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CityFlow.DataTransferObjects;

namespace CityFlow
{
    internal interface ISystemConfigurator
    {
        AdministratorData PreparePromotionToAdmin(Employee employeeToPromote);
        OperatorData PrepareDemotionToOperator(Administrator adminToDemote);
        void UpdateSystemSettings(SystemSettings newSettings);
        string TriggerLogArchiving(DateTime archiveBeforeDate);

    }
}
