using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace hash_sazimaj
{
    public class UserManager
    {
        private const string FilePath = "users.xml";
        public List<User> Users { get; private set; } = new List<User>();

        public UserManager()
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            if (File.Exists(FilePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    using (FileStream fs = new FileStream(FilePath, FileMode.Open))
                    {
                        Users = (List<User>)serializer.Deserialize(fs);
                    }
                }
                catch
                {
                    Console.WriteLine("Chyba při načítání XML, vytvářím nový soubor.");
                    File.Delete(FilePath);
                    CreateDefaultAdmin();
                }
            }
            else
            {
                CreateDefaultAdmin();
            }
        }

        private void CreateDefaultAdmin()
        {
            Users = new List<User>
    {
        new Admin { Username = "admin", PasswordHash = User.HashPassword("admin") }
    };
            SaveUsers();
        }

        public void SaveUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                serializer.Serialize(fs, Users);
            }
        }

        public User Authenticate(string username, string password)
        {
            return Users.FirstOrDefault(u => u.Username == username && u.VerifyPassword(password));
        }

        public void ResetPassword(string username, string newPassword)
        {
            User user = Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                user.PasswordHash = User.HashPassword(newPassword);
                SaveUsers();
            }
        }
    }
}
