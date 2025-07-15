using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public class MaintanceRecord
    {
        public MaintanceRecord(DateTime dateTime, string discription, decimal cost)
        {
            DateTime = dateTime;
            Discription = discription;
            Cost = cost;
        }

        public DateTime DateTime { get; set; }
        public string Discription { get; set; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return $"{DateTime.ToShortDateString()} - {Discription} - {Cost:C}";
        }
    }
}
