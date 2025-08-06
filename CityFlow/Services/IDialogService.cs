using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow.Services
{
    public enum DialogResult
    {
        Ok,
        Cancel,
        Yes,
        No
    }
    internal interface IDialogService
    {
        void ShowMessage(string message, string caption);
        void ShowError(string message, string caption);
        DialogResult ShowConfirmation(string message, string caption);
    }
}
