using System.ComponentModel;

namespace IssueTracker.Models
{
    public class TicketType
    {
        public int Id { get; set; }

        [DisplayName("Type Name")]
        public string Name { get; set; }
    }
}
