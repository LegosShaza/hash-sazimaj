using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace hash_sazimaj
{
    [Serializable]
    public class User
    {
        [XmlElement("Username")]
        public string Username { get; set; }

        [XmlElement("PasswordHash")]
        public string PasswordHash { get; set; }

        [XmlElement("IsAdmin")]
        public bool IsAdmin { get; set; }
    }
}
