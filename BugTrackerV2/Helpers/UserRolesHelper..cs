using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BugTrackerV2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;




namespace BugTrackerV2.Helpers

{
    public class UserRolesHelper
    {
        private UserManager<Users> userManager = new UserManager<Users>(new UserStore<Users>(new ApplicationDbContext()));
        private ApplicationDbContext db = new ApplicationDbContext();

        public bool IsUserInRole(string userId, string roleName)
        {
            return userManager.IsInRole(userId, roleName);
        }

        public ICollection<string> ListUserRoles(string userId)
        {
            return userManager.GetRoles(userId);
        }

        public bool AddUserToRole(string userId, string roleName)
        {
            var result = userManager.AddToRole(userId, roleName);
            return result.Succeeded;
        }

        public bool RemoveUserFromRole(string userId, string roleName)
        {
            var result = userManager.RemoveFromRole(userId, roleName);
            return result.Succeeded;
        }

        public ICollection<Users> UsersInRole(string roleName)
        {
            var resultList = new List<Users>();
            var List = userManager.Users.ToList();
            foreach (var user in List)
            {
                if (IsUserInRole(user.Id, roleName))
                    resultList.Add(user);
            }
            return resultList;
        }

        public ICollection<Users> UsersNotInRole(string roleName)
        {
            var resultList = new List<Users>();
            var List = userManager.Users.ToList();
            foreach (var user in List)
            {
                if (!IsUserInRole(user.Id, roleName))
                    resultList.Add(user);
            }
            return resultList;
        }


    }
}