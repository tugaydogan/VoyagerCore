using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Ticket")]
    public class TicketPoc
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ExpeditionPoc")]
        [Required]
        public int ExpeditionId { get; set; }
        [Required]
        public int SeatNumber { get; set; }
        [ForeignKey("PersonPoc")]
        [Required]
        public int PersonId { get; set; }
        [Required]
        public decimal PaidAmount { get; set; }


        public ExpeditionPoc Expedition { get; set; }
    }
}
