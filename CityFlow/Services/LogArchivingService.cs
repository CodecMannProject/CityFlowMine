using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow.Services
{
    public class LogArchivingService
    {
        public int Archive(DateTime date)
        {
            Console.WriteLine($"...Виконується архівація до {date.ToShortDateString()}...");
            return 1500;
        }
    }
}
