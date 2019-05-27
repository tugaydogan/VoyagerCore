using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Host")]
    public class HostPoc
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PersonPoc")]
        [Required]
        public int PersonId { get; set; }

        //One To Many(Many to Many (Expedition))
        //Collection Reference Navigation Property
        public  ICollection<ExpeditionHosts> ExpeditionHosts { get; set; }


        //One To Many
        //Reference Navigation Property
        public PersonPoc Person { get; set; }
    }
}
