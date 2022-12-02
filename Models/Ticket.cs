using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace IssueTracker.Models
{
    public class Ticket
    {
        /// -- Primary Key most the time
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Created")]
        public DateTimeOffset Created { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Updated")]
        public DateTimeOffset? Updated { get; set; }  
        // -- ? Means Database can accept NULL for this field 

        [DisplayName("Archived")]
        public bool Archived { get; set; }


        // --- Foreign Keys ---  //
        [DisplayName("Project")]
        public int ProjectId { get; set; }

        [DisplayName("Ticket Type")]
        public int TicketTypeId { get; set; }

        [DisplayName("Ticket Priority")]
        public int TicketPriorityId { get; set; }

        [DisplayName("Ticket Priority")]
        public int TicketStatusId { get; set; }

        [DisplayName("Ticket Owner")]
        public string OwnerUserId { get; set; }

        [DisplayName("Ticket Priority")]
        public string DeveloperUserId { get; set; }

       // -----   Navigation properties    -----    //

        public virtual Project Project { get; set; }
        
        public virtual TicketType? TicketType { get; set; }

        public virtual TicketPriority? TicketPriority { get; set; }

        public virtual TicketStatus? TicketStatus { get; set; }

        public virtual BTUser? OwnerUser { get; set; }

        public virtual BTUser? DeveloperUser { get; set; }

        

    }
}
