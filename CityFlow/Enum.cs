using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow
{
    public enum EmployeeStatus
    {
        Active,
        Blocked,
        OnLeave,
        OnVacation,
        SickLeave,
        Terminated,
    }
    public enum DriverStatus
    {
        Available,
        OnRoute,
        InIncident,
        OnBreak,
        SickLeave,
        OnVocation,
        Fired,
    }

    public enum VehicleStatus
    {
        Available,
        InDepot,
        OnRoute,
        InService,
        UnderMaintenance,
        InIncident,
        OutOfService
    }
    public enum VechicleType
    {
        Bus,
        Tram,
        Electrobus,
        Trolleybus,
    }

    public enum RouteStatus
    {
        Planned,
        InProgress,
        Completed,
        Cancelled,
    }
    public enum StopType
    {
        BusStop,
        TrainStation,
        TramStop,
    }
    public enum TicketType
    {
        SingleJourney,
        DayPass,
        WeeklyPass,
        MonthlyPass,
        AnnualPass,
    }
    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        MobilePayment,
        ContactlessCard,
        Voucher,
    }
    public enum IncidentType
    {
        Accident,
        Breakdown,
        Delay,
        Vandalism,
        WeatherDisruption,
    }

}
