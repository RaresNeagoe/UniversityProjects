using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel
{
    public class User
    {
        public string Username{ get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is User))
            {
                return false;
            }

            User u = obj as User;

            return Username == u.Username &&
                    Password == u.Password &&
                    Email == u.Email;
        }
    }
}
