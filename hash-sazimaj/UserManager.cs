using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace hash_sazimaj
{
    public class UserManager
    {
        public List<User> Users { get; private set; } = new List<User>();
        private string filePath = "users.xml";

        public UserManager()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        Users = (List<User>)serializer.Deserialize(fs);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Chyba při načítání XML. Vytvářím nový soubor.");
                    File.Delete(filePath);
                    Users = new List<User> { new User { Username = "admin", PasswordHash = ComputeHash("admin"), IsAdmin = true } };
                    SaveUsers();
                }
            }
            else
            {
                Users = new List<User> { new User { Username = "admin", PasswordHash = ComputeHash("admin"), IsAdmin = true } };
                SaveUsers();
            }
        }

        public void SaveUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, Users);
            }
        }

        public User Authenticate(string username, string password)
        {
            string hash = ComputeHash(password);
            return Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == hash);
        }

        public void AddUser(string username, string password, bool isAdmin)
        {
            Users.Add(new User { Username = username, PasswordHash = ComputeHash(password), IsAdmin = isAdmin });
            SaveUsers();
        }

        public void ResetPassword(string username, string newPassword)
        {
            var user = Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                user.PasswordHash = ComputeHash(newPassword);
                SaveUsers();
            }
        }

        public void DeleteUser(string username)
        {
            Users.RemoveAll(u => u.Username == username);
            SaveUsers();
        }

        private string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
