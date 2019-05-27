using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("ExpeditionDrivers")]
    public class ExpeditionDrivers
    {
        [ForeignKey("DriverPoc")]
        [Required]
        public int DriverId { get; set; }
        [ForeignKey("ExpeditionPoc")]
        [Required]
        public int ExpeditionId { get; set; }

        public virtual DriverPoc Driver { get; set; }
        public virtual ExpeditionPoc Expedition { get; set; }

    }
}
