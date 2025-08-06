using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CityFlow
{
    internal abstract class User : IAuthenticatable
    {
        public Guid Id { get; private set; }
        public string Login { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{LastName} {FirstName}";
        private string _passwordHash;

        protected User(string login, string password, string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            _passwordHash = HashPassword(password);
        }

        public bool VerifyPassword(string passwordToVerify)
        {
            if (string.IsNullOrEmpty(passwordToVerify)) return false;
            string hashedPassword = HashPassword(passwordToVerify);
            return hashedPassword == _passwordHash;
        }
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword) || newPassword.Length < 10)
            {
                MessageBox.Show("New password must be at least 10 characters long.");
                throw new ArgumentException("New password must be at least 10 characters long.");
            }
            _passwordHash = HashPassword(newPassword);
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
            return _passwordHash;
        }

        public abstract string GetRoleDescription();
    }
}
