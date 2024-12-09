using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    [Serializable]
    [DataContract]
    internal class User
    {
        public User(string login, string password, int year, int month, int day)
        {
            this.Login = login;
            this.Password = password;
            this.Id = 0;
            this.birthday = new(year, month, day);
        }
        public User(string login, string password, int id, int year, int month, int day)
        {
            this.Login = login;
            this.Password = password;
            this.Id = id;
            this.birthday = new(year, month, day);
        }
        private DateOnly birthday;

        [DataMember]
        public string? Login { get; set; }
        [DataMember]
        public string? Password { get; set; }
        [DataMember]
        public int Id {  get; set; }
        [DataMember]
        public string Birthday
        {
            get
            {
                return birthday.ToString("yyyy-MM-dd");
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    birthday = DateOnly.Parse(value);
                }
                else
                {
                    birthday = default;
                }
            }
        }

        public override string ToString()
        {
            return $"Login: {Login}, Password: {Password}, Id: {Id} Date: {Birthday}";
        }
    }
}
