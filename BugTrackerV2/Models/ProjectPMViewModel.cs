using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BugTrackerV2.Models;

namespace BugTrackerV2.Models
{
    public class ProjectPMViewModel
    {
      public Project Project { get; set; }
      public ApplicationUser ProjectManager { get; set; }
    }
}