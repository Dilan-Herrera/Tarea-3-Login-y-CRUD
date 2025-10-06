using System.Collections.Generic;

namespace ProyectoMVC.Models
{
    public static class User
    {
        private static Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "admin", "1234" },
            { "dilan", "abcd" }
        };

        public static bool Authenticate(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }
    }
}
