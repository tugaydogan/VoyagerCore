using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Driver")]
    public class DriverPoc
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PersonPoc")]
        [Required]
        public int PersonId { get; set; }

        [Required]
        public LicenseType LicenseType { get; set; }

        //One To Many
        //Collection Reference Navigation Property
        public virtual ICollection<ExpeditionDrivers> ExpeditionDrivers { get; set; }

        //One To One
        //Reference Navigation Property
        public PersonPoc Person { get; set; }
    }
}
