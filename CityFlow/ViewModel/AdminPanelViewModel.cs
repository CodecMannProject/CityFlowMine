using CityFlow.Model;
using CityFlow.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow.ViewModel
{
    internal class AdminPanelViewModel : BaseViewModel
    {
        protected readonly TransportSystem _transportSystem;
        protected readonly Employee _currentUser;
        protected readonly IDialogService _dialogService;

        private Employee _selectedEmployee;

        public ObservableCollection<Employee> Employees { get; }
        public ObservableCollection<TransportVehicle> Vehicles { get; }
        public ObservableCollection<Route> Routes { get; }
        public ObservableCollection<Stop> Stops { get; }

        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (_selectedEmployee != value)
                {
                    _selectedEmployee = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(CanEditEmployee));
                    OnPropertyChanged(nameof(CanFireEmployee));
                }
            }
        }

        public bool CanEditEmployee => SelectedEmployee != null;
        public bool CanFireEmployee => SelectedEmployee != null && SelectedEmployee.Status != EmployeeStatus.OnLeave;

        public AdminPanelViewModel(TransportSystem transportSystem, Employee currentUser, IDialogService dialogService)
        {
            _transportSystem = transportSystem ?? throw new ArgumentNullException(nameof(transportSystem));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));

            var manageableEmployees = _transportSystem.AllEmployees
                .Where(e => currentUser.EmployeeId != e.EmployeeId && !(e is SuperAdmin))
                .ToList();

            if (currentUser is Administrator && !(currentUser is SuperAdmin))
            {
                manageableEmployees = manageableEmployees
                .Where(e => currentUser.EmployeeId != e.EmployeeId && !(e is SuperAdmin))
                .ToList();
            }

            Employees = new ObservableCollection<Employee>(manageableEmployees);
            _dialogService = dialogService;
        }
        public void FireSelectedEmployee()
        {
            if (!CanFireEmployee) return;
            var result = _dialogService.ShowConfirmation("Are you sure you want to fire this employee?", "Confirm Fire");
            if (result == Services.DialogResult.Yes)
            {
                _transportSystem.FireEmployee(SelectedEmployee);
                Employees.Remove(SelectedEmployee);
                SelectedEmployee = null;
                _dialogService.ShowMessage("Employee has been fired successfully.", "Success");
            }
        }
    }
}
