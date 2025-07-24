using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CityFlow
{
    internal abstract class User: IAuthenticatable
    {
        protected Guid idUser;
        protected string name;
        protected string surname;
        protected string login;
        protected string passwordHash;

        protected User( string login, string passwordHash, string name, string surname)
        {
            this.idUser = Guid.NewGuid();
            this.login = login;
            this.passwordHash = passwordHash;
            this.name = name;
            this.surname = surname;
        }

        public bool VerifyPassword(string passwordToVerify)
        {
            if (string.IsNullOrEmpty(passwordToVerify)) return false;
            string hashedPassword = HashPassword(passwordToVerify);
            return hashedPassword == passwordHash;
        }
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword)|| newPassword.Length <10)
            {
                MessageBox.Show("New password must be at least 10 characters long.");
                throw new ArgumentException("New password must be at least 10 characters long.");
            }
            passwordHash = HashPassword(newPassword);
            return true;
        }

        private string HashPassword(string passwordToVerify)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(passwordToVerify));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public string GetPasswordHash()
        {
            return passwordHash;
        }
        public string FullName
        {
            get { return $"{name} {surname}"; }
        }

        public abstract string GetRoleDescription();
    }
}
