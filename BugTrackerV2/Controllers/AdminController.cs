using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTrackerV2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

//made this in demo with antonio
namespace BugTrackerV2.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        Helpers.UserRolesHelper helper = new Helpers.UserRolesHelper();

        // GET: Admin
        public ActionResult Index()
        {
            List<UsersViewModel> users = new List<UsersViewModel>();
            var dbUsers = db.Users.ToList();

            foreach (var usr in dbUsers)
            {
                UsersViewModel vm = new UsersViewModel();
                vm.User = usr;
                vm.Roles = helper.ListUserRoles(usr.Id).ToList();
                users.Add(vm);
            }



            return View(users);
        }
        public ActionResult AddUserRole()
        {
            ViewBag.Users = new SelectList(db.Users,"Id","FirstName");
            ViewBag.Roles = new SelectList(db.Roles, "Name", "Name");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddUserRole(string Users, string Roles)
        {
            helper.AddUserToRole(Users, Roles);
            return RedirectToAction("Index");
        }




        public ActionResult RemoveUserRole()
        {
            ViewBag.Users = new SelectList(db.Users, "Id", "FirstName");
            ViewBag.Roles = new SelectList(db.Roles, "Name", "Name");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveUserRole(string Users, string Roles)
        {
            ApplicationUser usr = db.Users.Find();
            if (helper.IsUserInRole(usr.Id, Roles) == true)
            {
                helper.RemoveUserFromRole(usr.Id, Roles);
                return RedirectToAction("Index");
            }
            else
            { return View(); }
        }











    }
}