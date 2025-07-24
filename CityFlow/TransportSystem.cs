using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public class TransportSystem
    {
        internal BindingList<Employee> AllEmployees { get; private set; }
        public BindingList<Driver> Drivers { get; private set; }
        public BindingList<Bus> Buss { get; private set; }
        public BindingList<Stop> Stops { get; private set; }
        public BindingList<Route> Routes { get; private set; }

        public TransportSystem()
        {
            Drivers = new BindingList<Driver>();
            Buss = new BindingList<Bus>();
            Stops = new BindingList<Stop>();
            Routes = new BindingList<Route>();
        }

        
        internal List<Operator> operators { get; private set; }

        #region Керування водіями

        public Driver HireDriver(Guid employeeId, string firstName, string lastName, DateTime dateOfBirth)
        {
            var newDriver = new Driver(employeeId, firstName, lastName, dateOfBirth);
            Drivers.Add(newDriver);
            return newDriver;
        }

        
        public void FireDriver(Driver driver)
        {
            if (driver != null && Drivers.Contains(driver))
            {
                Drivers.Remove(driver);
                Console.WriteLine($"Driver {driver.FullName} removed from the system.");
            }
            else
            {
                Console.WriteLine("Driver not found or is null.");
            }
        }
        #endregion

        internal void PromoteEmployeeToAdmin(SuperAdmin promoter, Employee employeeToPromote)
        {
            // 1. Суперадмін готує "пакет" даних
            var adminData = promoter.PreparePromotion(employeeToPromote);

            // 2. Створюємо нового адміністратора
            var newAdmin = new Administrator(adminData.EmployeeId, adminData.Login, "temp_pass", adminData.FirstName, adminData.LastName, EmployeeStatus.Active);

            // 3. Видаляємо старий об'єкт співробітника зі списку
            this.AllEmployees.Remove(employeeToPromote);

            // 4. Додаємо новий об'єкт адміністратора
            this.AllEmployees.Add(newAdmin);
        }

        #region Керування автобусами   
        public Bus RegisterNewBus(string licensePlate, string model, string garageNumber, int capacity, int seats, VechicleStatus status)
        {
            var newBus = new Bus(licensePlate, model, garageNumber, capacity, seats, status);
            Buss.Add(newBus);
            return newBus;
        }
        public void SendBusToRepair(Bus bus)
        {
            if (bus != null && Buss.Contains(bus))
            {
                bus.SendToRepair();
                Console.WriteLine($"Bus {bus.ToString()} sent for maintenance.");
            }
            else
            {
                Console.WriteLine("Bus not found or is null.");
            }
        }
        public void ReturnBusFromRepair(Bus bus)
        {
            if (bus != null && Buss.Contains(bus))
            {
                bus.GoOnRoute();
                Console.WriteLine($"Bus {bus.ToString()} returned from maintenance.");
            }
            else
            {
                Console.WriteLine("Bus not found or is null.");
            }
        }
        #endregion
        #region Операційна діяльність
        public void AssignRouteToBus(Bus bus, Route route)
        {
            var driver = Drivers.FirstOrDefault(d => d.AssignedBus == bus);
            var existingBus = Buss.FirstOrDefault(b => b == bus);

            if (driver != null && existingBus != null && Routes.Contains(route))
            {
                //route.vechicleType = bus.VechicleType;
                route.StartStop = Stops.FirstOrDefault(s => s.Name == route.StartStop.Name);
                route.EndStop = Stops.FirstOrDefault(s => s.Name == route.EndStop.Name);
                Console.WriteLine($"Route {route.Number} assigned to bus {bus.ToString()} with driver {driver.FullName}.");
            }
            else
            {
                Console.WriteLine("Driver, bus, or route not found or is null.");
            }
        }
        internal void CompleteShift(Operator operatorObj)
        {
            if (operators.Contains(operatorObj))
            {
                Console.WriteLine($"Operator {operatorObj.FullName} has completed their shift.");
                /* foreach (var bus in operatorObj.Buss)
                {
                    bus.Status = VechicleStatus.InDepot;
                    Console.WriteLine($"Bus {bus.ToString()} is now in depot.");
                }*/
            }
            else
            {
                Console.WriteLine("Operator not found or is null.");
            }
        }

        internal void CompleteShift(Guid employeeId, double mileage)
        {
            throw new NotImplementedException();
        }

        internal void AssignDriverToBusOnRoute(Guid employeeId)
        {

        }
        #endregion
    }
}