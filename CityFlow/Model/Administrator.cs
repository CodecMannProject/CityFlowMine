using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow.Model
{
    internal class Administrator : Employee, IUserManager
    {
        public Administrator(string EmployeeId, string login, string passwordHash, string firstName, string lastName, EmployeeStatus status) : base(EmployeeId, login, passwordHash, firstName, lastName, status)
        {
        }
        public override string GetRoleDescription() => "Administrator: Manages the transport system, oversees operations, and ensures compliance with regulations.";

        public void ResetPasswordFor(Employee targetEmployee, string newTemporaryPassword)
        {
            // 1. Валідація ("Guard Clauses")
            if (targetEmployee == null)
                throw new ArgumentNullException(nameof(targetEmployee));

            if (string.IsNullOrWhiteSpace(newTemporaryPassword) || newTemporaryPassword.Length < 8)
                throw new ArgumentException("Наданий пароль не є надійним.", nameof(newTemporaryPassword));
            if (targetEmployee.Id == this.Id)
                throw new InvalidOperationException("Неможливо скинути пароль для самого себе через цей метод.");

            if (targetEmployee is Administrator) // Ця перевірка також "зловить" і SuperAdmin
                throw new InvalidOperationException("Недостатньо прав для скидання пароля іншого адміністратора.");

            targetEmployee.ChangePassword(this.GetPasswordHash(), newTemporaryPassword);

            LogAction($"Скинуто пароль для користувача {targetEmployee.FullName}");
        }

        public void BlockAccount(Employee targetEmployee)
        {

            if (targetEmployee == null)
                throw new ArgumentNullException(nameof(targetEmployee));

            if (targetEmployee.Id == this.Id)
                throw new InvalidOperationException("Неможливо заблокувати самого себе.");

            if (targetEmployee is Administrator)
                throw new InvalidOperationException("Недостатньо прав для блокування іншого адміністратора.");

            if (targetEmployee.Status == EmployeeStatus.Terminated)
                throw new InvalidOperationException("Обліковий запис вже є неактивним (звільнений).");

            targetEmployee.SetStatus(EmployeeStatus.Blocked);

            LogAction($"Заблоковано обліковий запис {targetEmployee.FullName}");
        }

        public void UnblockAccount(Employee targetEmployee)
        {
            if (targetEmployee == null)
                throw new ArgumentNullException(nameof(targetEmployee));

            if (targetEmployee.Status != EmployeeStatus.Blocked)
                throw new InvalidOperationException("Цей обліковий запис не є заблокованим.");

            targetEmployee.SetStatus(EmployeeStatus.Active);

            LogAction($"Розблоковано обліковий запис {targetEmployee.FullName}");
        }

        private void LogAction(string action)
        {
            //Logger.Info($"Admin Action by {this.FullName} (ID: {this.EmployeeId}): {action}");
            Console.WriteLine($"[LOG] Admin Action by {this.FullName}: {action}");
        }
    }
}
