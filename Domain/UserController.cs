﻿using System;
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

        public DataTable SearchUser(string user)
        {
            DataTable TableUsers = new DataTable();
            TableUsers = userData.SearchUser(user);
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

        public void SelectUserById(Int64 user_id)
        {
            userData.SelectUserById(user_id);
        }

        public void UpdateUser(string name, string lastname, string username, string password, string email, string phone, string role_id, string optometrist, string consultant, string manager, string user_status_id, Int64 user_id, string updated_at)
        {
            userData.UpdateUser(name, lastname, username, password, email, phone, Convert.ToInt64(role_id), Convert.ToBoolean(optometrist), Convert.ToBoolean(consultant), Convert.ToBoolean(manager), Convert.ToInt64(user_status_id), user_id, Convert.ToDateTime(updated_at));
        }

        public DataTable SelectAllRoles()
        {
            DataTable TableRoles = new DataTable();
            TableRoles = userData.SelectAllRoles();
            return TableRoles;
        }
        public DataTable SelectUsersByRoleId(string role_id)
        {
            DataTable TableUsers = new DataTable();
            TableUsers = userData.SelectUsersByRoleId(Convert.ToInt64(role_id));
            return TableUsers;
        }
        public DataTable SelectUsersIsOptometrist()
        {
            DataTable TableUsers = new DataTable();
            TableUsers = userData.SelectUsersIsOptometrist();
            return TableUsers;
        }
        public DataTable SelectUsersIsConsultant()
        {
            DataTable TableUsers = new DataTable();
            TableUsers = userData.SelectUsersIsConsultant();
            return TableUsers;
        }
        public DataTable SelectUsersIsManager()
        {
            DataTable TableUsers = new DataTable();
            TableUsers = userData.SelectUsersIsManager();
            return TableUsers;
        }
        public DataTable SelectAllstatus()
        {
            DataTable TableStatus = new DataTable();
            TableStatus = userData.SelectAllStatus();
            return TableStatus;
        }

        public void CreateUser(string name, string lastname, string username, string password, string email, string phone, string role_id, string optometrist, string consultant, string manager, string user_status_id, string created_at)
        {
            userData.CreateUser(name, lastname, username, password, email, phone, Convert.ToInt64(role_id), Convert.ToBoolean(optometrist), Convert.ToBoolean(consultant), Convert.ToBoolean(manager), Convert.ToInt64(user_status_id), Convert.ToDateTime(created_at));
        }

        public void DeleteUser(Int64 user_id)
        {
            userData.DeleteUser(user_id);
        }
    }
}
