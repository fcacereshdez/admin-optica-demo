using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
  public static class UserCache
    {
        public static Int64 user_id { get; set; }
        public static string name { get; set; }
        public static string lastname { get; set; }
        public static string password { get; set; }
        public static string email { get; set; }
        public static string role { get; set; }
        public static string slug_role { get; set; }
        public static bool is_optometrist { get; set; }
        public static bool is_consultant { get; set; }
        public static bool is_manager { get; set; }

    }
}
