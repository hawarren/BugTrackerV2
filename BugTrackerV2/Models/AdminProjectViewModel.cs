﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTrackerV2.Models
{
    public class AdminProjectViewModel
    {
        public Project Project { get; set; }
        //public ICollection<ApplicationUser> ProjectManagers { get; set; }
        //SelectList is a type that allows dropdown
        public SelectList PMUsers { get; set; }
        public string SelectedUser { get; set; }
    }
}