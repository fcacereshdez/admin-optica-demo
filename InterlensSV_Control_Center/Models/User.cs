using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterlensSV_Control_Center.Models
{
    class User
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Lastname { get; set; }
        public static string Username { get; set; }
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static string Lastlogin { get; set; }
        public string Role { get; set; }
    }
}
