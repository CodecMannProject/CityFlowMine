using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityFlow.Model;

namespace CityFlow.ViewModel
{
    internal class LoginScreenViewModel : BaseViewModel
    {
        private readonly TransportSystem _transportSystem;

        private string _login;
        private string _password;
        private string _errorMessage;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged();
            }
        }

        public event Action<User>? LoginSuccess;

        public LoginScreenViewModel(TransportSystem transportSystem)
        {
            _transportSystem = transportSystem;
        }

        public void AttemptLogin()
        {
            ErrorMessage = string.Empty;

            try
            {
                var user = _transportSystem.AuthenticateUser(Login, Password);

                if (user != null)
                {
                    LoginSuccess?.Invoke(user);
                }
                else
                {
                    ErrorMessage = "Invalid login or password.";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return;
            }
        }
    }
}
