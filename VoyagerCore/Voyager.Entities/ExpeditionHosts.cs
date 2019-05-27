using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("ExpeditionHosts")]
    public class ExpeditionHosts
    {
        [ForeignKey("HostPoc")]
        [Required]
        public int HostId { get; set; }
        [ForeignKey("ExpeditionPoc")]
        [Required]
        public int ExpeditionId { get; set; }

        //Many To Many(Host - Expedition)
        //Reference Navigation Property
        public virtual HostPoc Host { get; set; }
        public virtual ExpeditionPoc Expedition { get; set; }
    }
}
