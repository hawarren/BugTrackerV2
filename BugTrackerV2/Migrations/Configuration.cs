namespace BugTrackerV2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BugTrackerV2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BugTrackerV2.Models.ApplicationDbContext context)
        {

            var roleManager = new RoleManager<IdentityRole>(
            new RoleStore<IdentityRole>(context));

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
            }

            if (!context.Roles.Any(r => r.Name == "ProjectManager"))
            {
                roleManager.Create(new IdentityRole { Name = "ProjectManager" });
            }

            if (!context.Roles.Any(r => r.Name == "Developer"))
            {
                roleManager.Create(new IdentityRole { Name = "Developer" });
            }

            if (!context.Roles.Any(r => r.Name == "Submitter"))
            {
                roleManager.Create(new IdentityRole { Name = "Submitter" });
            }



            var userManager = new UserManager<ApplicationUser>(
            new UserStore<ApplicationUser>(context));

            if (!context.Users.Any(u => u.Email == "hanifwarren@gmail.com"))
            {
                userManager.Create(new ApplicationUser {
                    UserName = "hanifwarren@gmail.com",
                    Email = "hanifwarren@gmail.com",
                    FirstName = "Hanif",
                    LastName = "Warren",
                    DisplayName = "Hanif Warren"
                }, "12345678");
            }



            var userId = userManager.FindByEmail("hanifwarren@gmail.com").Id;
            userManager.AddToRole(userId, "Admin");
            userManager.AddToRole(userId, "ProjectManager");
            userManager.AddToRole(userId, "Submitter");
            userManager.AddToRole(userId, "Developer");


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (!context.Users.Any(u => u.Email == "testuser1@btracker.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "testuser1@btracker.com",
                    Email = "testuser1@btracker.com",
                    FirstName = "Test1",
                    LastName = "User1",
                    DisplayName = "Imatest1"
                }, "Abc&123!");
            }


            if (!context.Users.Any(u => u.Email == "testuser2@btracker.com"))
            {

                userManager.Create(new ApplicationUser
                {
                    UserName = "testuser2@btracker.com",
                    Email = "testuser2@btracker.com",
                    FirstName = "Test2",
                    LastName = "User2",
                    DisplayName = "Imatest2"
                }, "Abc&123!");
            }


            if (!context.Users.Any(u => u.Email == "testuser3@btracker.com"))
            {

                userManager.Create(new ApplicationUser
                {
                    UserName = "testuser3@btracker.com",
                    Email = "testuser3@btracker.com",
                    FirstName = "Test3",
                    LastName = "User3",
                    DisplayName = "Imatest3"
                }, "Abc&123!");
            }


            if (!context.Users.Any(u => u.Email == "testuser4@btracker.com"))
            {

                userManager.Create(new ApplicationUser
                {
                    UserName = "testuser4@btracker.com",
                    Email = "testuser4@btracker.com",
                    FirstName = "Test4",
                    LastName = "User4",
                    DisplayName = "Imatest4"
                }, "Abc&123!");
            }


            if (!context.Users.Any(u => u.Email == "testuser5@btracker.com"))
            {

                userManager.Create(new ApplicationUser
                {
                    UserName = "testuser5@btracker.com",
                    Email = "testuser5@btracker.com",
                    FirstName = "Test5",
                    LastName = "User5",
                    DisplayName = "Imatest5"
                }, "Abc&123!");
            }


            if (!context.Users.Any(u => u.Email == "testuser6@btracker.com"))
            {

                userManager.Create(new ApplicationUser
                {
                    UserName = "testuser6@btracker.com",
                    Email = "testuser6@btracker.com",
                    FirstName = "Test6",
                    LastName = "User6",
                    DisplayName = "Imatest6"
                }, "Abc&123!");
            }

            
            if (!context.TicketTypes.Any(r => r.Name == "Bug"))

            { context.TicketTypes.Add(new TicketType { Name = "Production Fix" });

            }
            
            if (!context.TicketTypes.Any(r => r.Name == "Project Task"))
            {
                context.TicketTypes.Add(new TicketType { Name = "Project Task" });
            }

            if (!context.TicketTypes.Any(r => r.Name == "Software Update"))
            {
                context.TicketTypes.Add(new TicketType { Name = "Software Update" });
            }


            if (!context.TicketPriorities.Any(r => r.Name == "Low"))

            {
                context.TicketPriorities.Add(new TicketPriority { Name = "Low" });

            }

            if (!context.TicketPriorities.Any(r => r.Name == "Medium"))
            {
                context.TicketPriorities.Add(new TicketPriority { Name = "Medium" });
            }

            if (!context.TicketPriorities.Any(r => r.Name == "High"))
            {
                context.TicketPriorities.Add(new TicketPriority { Name = "High" });
            }
            if (!context.TicketPriorities.Any(r => r.Name == "ExtremeDanger"))
            {
                context.TicketPriorities.Add(new TicketPriority { Name = "ExtremeDanger" });
            }


            if (!context.TicketStatus.Any(r => r.Name == "Open"))
            {
                context.TicketStatus.Add(new TicketStatus { Name = "Open" });
            }


            if (!context.TicketStatus.Any(r => r.Name == "New"))
            {
                context.TicketStatus.Add(new TicketStatus { Name = "New" });
            }

            if (!context.TicketStatus.Any(r => r.Name == "Closed"))
            {
                context.TicketStatus.Add(new TicketStatus { Name = "Closed" });
            }

            if (!context.TicketStatus.Any(r => r.Name == "WontFix"))
            {
                context.TicketStatus.Add(new TicketStatus { Name = "WontFix" });
            }
            if (!context.TicketStatus.Any(r => r.Name == "UnderReview"))
            {
                context.TicketStatus.Add(new TicketStatus { Name = "UnderReview" });
            }

        }
    }
}


