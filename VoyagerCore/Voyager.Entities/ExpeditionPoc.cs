using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Expedition")]
    public class ExpeditionPoc
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Route")]
        [Required]
        public int RouteId { get; set; }
        [ForeignKey("Bus")]
        [Required]
        public int BusId { get; set; }
        [Required]
        public DateTime EstimatedDepartureTime { get; set; }
        [Required]
        public DateTime EstimatedArrivalTime { get; set; }
        [Required]
        public bool HasSnackService { get; set; }

        [MaxLength(64)]
        [Required]
        public string DepartureLocation { get; set; }
        [MaxLength(64)]
        [Required]
        public string ArrivalLocation { get; set; }
        [Required]
        public int Distance { get; set; }
        [MaxLength(64)]
        [Required]
        public string RouteName { get; set; }

        [ForeignKey("ExpeditionDrivers")]
        [Required]
        public int ExpeditionDriversId { get; set; }
        [ForeignKey("ExpeditionHosts")]
        [Required]
        public int ExpeditionHostsId { get; set; }


        public ExpeditionHosts expeditionHosts { get; set; }
        public ExpeditionDrivers expeditionDrivers { get; set; }
        public TicketPoc Ticket { get; set; }
        public BusPoc Bus { get; set; }
        public RoutePoc Route { get; set; }

    }
}
