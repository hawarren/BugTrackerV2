﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugTrackerV2.Models
{
    public class TicketStatus
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}