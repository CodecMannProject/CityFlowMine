using CityFlow.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CityFlow.DataTransferObjects;

namespace CityFlow.Model
{
    internal class SuperAdmin : Administrator
    {
        public SuperAdmin(string EmployeeId, string login, string passwordHash, string firstName, string lastName, EmployeeStatus status) : base(EmployeeId, login, passwordHash, firstName, lastName, status)
        {
        }
        public override string GetRoleDescription() => "SuperAdmin: Oversees all operations, manages system-wide settings, and has the highest level of access to the transport system.";

        public AdministratorData PreparePromotionToAdmin(Employee employeeToPromote)
        {
            if (employeeToPromote == null)
                throw new ArgumentNullException(nameof(employeeToPromote));

            if (employeeToPromote is Administrator)
                throw new InvalidOperationException("Цей співробітник вже є адміністратором.");

            if (employeeToPromote.Status == EmployeeStatus.OnLeave)
                throw new InvalidOperationException("Неможливо підвищити звільненого співробітника.");

            return new AdministratorData
            {
                EmployeeId = employeeToPromote.EmployeeId,
                Login = employeeToPromote.Login,
                FirstName = employeeToPromote.FirstName,
                LastName = employeeToPromote.LastName
            };
        }

        public OperatorData PrepareDemotionToOperator(Administrator adminToDemote)
        {
            // Валідація: не можна понизити самого себе або іншого суперадміна
            if (adminToDemote == null)
                throw new ArgumentNullException(nameof(adminToDemote));

            if (adminToDemote.EmployeeId == EmployeeId)
                throw new InvalidOperationException("Неможливо понизити самого себе.");

            if (adminToDemote is SuperAdmin)
                throw new InvalidOperationException("Неможливо понизити іншого суперадміністратора.");

            // Створюємо та повертаємо DTO
            return new OperatorData
            {
                EmployeeId = adminToDemote.EmployeeId,
                Login = adminToDemote.Login,
                FirstName = adminToDemote.FirstName,
                LastName = adminToDemote.LastName
            };
        }

        public void UpdateSystemSettings(SystemSettings newSettings)
        {

            if (newSettings == null)
                throw new ArgumentNullException(nameof(newSettings));

            // Валідація нових налаштувань
            if (newSettings.SessionTimeoutMinutes < 1)
                throw new ArgumentException("Тайм-аут сесії не може бути меншим за 1 хвилину.");

            // Уявний виклик сервісу
            SettingsService.Instance.ApplySettings(newSettings);

            Console.WriteLine($"Суперадміністратор {FullName} оновив налаштування системи.");
        }

        public string TriggerLogArchiving(DateTime archiveBeforeDate)
        {
            if (archiveBeforeDate > DateTime.Now)
                throw new ArgumentException("Дата для архівації не може бути в майбутньому.");

            // Делегування важкої роботи спеціалізованому сервісу
            var logService = new LogArchivingService();
            int archivedEntriesCount = logService.Archive(archiveBeforeDate);

            string report = $"Процес архівації запущено суперадміністратором {FullName}. " +
                            $"Архівування логів до {archiveBeforeDate:dd.MM.yyyy}. " +
                            $"Заархівовано записів: {archivedEntriesCount}.";

            Console.WriteLine(report);
            return report;
        }
    }
}