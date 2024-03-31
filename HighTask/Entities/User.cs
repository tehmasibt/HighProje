using HighTask.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HighTask.Entities
{
    internal class User : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Roles UserRole { get; set; }
        public User(string username, string email, Roles userRole)
        {
            Username = username;
            Email = email;
            UserRole = userRole;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Username: {Username}, Email: {Email}";
        }
    }
}
