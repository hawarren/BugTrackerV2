﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BugTrackerV2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class Users : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Users> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<Users>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<BugTrackerV2.Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<BugTrackerV2.Models.Ticket> Tickets { get; set; }
        
        public System.Data.Entity.DbSet<BugTrackerV2.Models.TicketPriority> TicketPriorities { get; set; }

        public System.Data.Entity.DbSet<BugTrackerV2.Models.TicketStatus> TicketStatus { get; set; }

        public System.Data.Entity.DbSet<BugTrackerV2.Models.TicketType> TicketTypes { get; set; }
    }
}