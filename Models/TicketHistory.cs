﻿using System.ComponentModel;

namespace IssueTracker.Models
{
    public class TicketHistory
    {
        public int Id { get; set; } //Primary Key for table

        [DisplayName("Ticket")]
        public int TicketId { get; set; }  // Foreign Key from Ticket table

        [DisplayName("Updated Item")]
        public string Property { get; set; }

        [DisplayName("Previous")]
        public string OldValue { get; set; }

        [DisplayName("Current")]
        public string NewValue { get; set; }

        [DisplayName("Date Modified")]
        public DateTimeOffset Created { get; set; }

        [DisplayName("Description of Change")]
        public string Description { get; set; }

        [DisplayName("Team Member")]
        public string UserId { get; set; } //Foreign Key - Relational Database


        //Navigation properties
        public virtual Ticket Ticket { get; set; }

        public virtual BTUser User { get; set; }

    }
}
