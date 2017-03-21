using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerV2.Models
{
    public class AdminProjectViewModel
    {
        public Project Project { get; set; }
        public ICollection<ApplicationUser> ProjectManagers { get; set; }
    }
}