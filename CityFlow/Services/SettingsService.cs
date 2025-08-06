using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityFlow.Services
{
    public class SettingsService
    {
        private static readonly SettingsService _instance = new SettingsService();

        public static SettingsService Instance => _instance;

        private SettingsService()
        {
            LoadSettingsFromFile();
        }

        internal SystemSettings CurrentSettings { get; private set; }

        internal void ApplySettings(SystemSettings newSettings)
        {
            // Створюємо копію, щоб уникнути несподіваних змін  
            CurrentSettings = new SystemSettings(newSettings);
            SaveSettingsToFile();
        }

        private void LoadSettingsFromFile()
        {
            CurrentSettings = new SystemSettings
            {
                SessionTimeoutMinutes = 30,
                IsBackupEnabled = true,
                BackupFolderPath = "./Backups",
                LogFilePath = "./Logs/app.log"
            };
            Console.WriteLine("Налаштування завантажено.");
        }

        private void SaveSettingsToFile()
        {
            Console.WriteLine("Налаштування збережено.");
        }
    }
}

internal class SystemSettings
{
    public int SessionTimeoutMinutes { get; set; }
    public string LogFilePath { get; set; }
    public bool IsBackupEnabled { get; set; }
    public string BackupFolderPath { get; set; }

    public SystemSettings() { }

    public SystemSettings(SystemSettings other)
    {
        SessionTimeoutMinutes = other.SessionTimeoutMinutes;
        LogFilePath = other.LogFilePath;
        IsBackupEnabled = other.IsBackupEnabled;
        BackupFolderPath = other.BackupFolderPath;
    }
}
