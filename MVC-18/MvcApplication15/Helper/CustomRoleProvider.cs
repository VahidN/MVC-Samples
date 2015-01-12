using System;
using System.Web.Security;

namespace MvcApplication15.Helper
{
    public class CustomRoleProvider : RoleProvider
    {
        public override bool IsUserInRole(string username, string roleName)
        {
            if (username.ToLowerInvariant() == "ali" && roleName.ToLowerInvariant() == "User")
                return true;
            // blabla ...
            return false;
        }

        public override string[] GetRolesForUser(string username)
        {
            if (username.ToLowerInvariant() == "ali")
            {
                return new[] { "User", "Helpdesk" };
            }

            if(username.ToLowerInvariant()=="vahid")
            {
                return new [] { "Admin" };
            }

            return new string[] { };
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }        

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }        

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}