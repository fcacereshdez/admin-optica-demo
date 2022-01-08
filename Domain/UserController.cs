using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Domain
{
    public class UserController
    {
        UserData userData = new UserData();
        public bool LoginUser(string username, string password)
        {
            return userData.Login(username, password);
        }

        public DataTable GetAllUsers()
        {
            DataTable TableUsers = new DataTable();
            TableUsers = userData.GetAllUsers();
            return TableUsers;
        }

        public void InsertActionsUser(string description, string computer, string ipaddress, Int64 user_id, string created_at)
        {
            userData.InsertActionsUser(description, computer, ipaddress, user_id, Convert.ToDateTime(created_at));
        }

        public void UpdateLastAccessUser(Int64 user_id, string last_access)
        {
            userData.UpdateLastAccessUser(user_id, Convert.ToDateTime(last_access));
        }
    }
}
