using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing_System.Models
{
    public class TicketHistory
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Change { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UpdatedById { get; set; }
        public string UpdatedByName { get; set; }

    }
}
