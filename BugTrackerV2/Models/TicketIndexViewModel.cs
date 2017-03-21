using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using BugTrackerV2.Models;

namespace BugTrackerV2.Models
{
    public class TicketIndexViewModel
    {
        public ApplicationUser User { get; set; }
        public List<string> Roles { get; set; }
        public List<Ticket> AdminTickets { get; set; }
        public List<Ticket> PMTickets { get; set; }
        public List<Ticket> DevTickets { get; set; }
        public List<Ticket> SubTickets { get; set; }


        //admin pm dev sub
    }
}