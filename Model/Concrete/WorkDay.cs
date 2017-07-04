using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class WorkDay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public virtual Doctor Doctor { get; set; }

        [Required]
        public int From_hour { get; set; }
        [Required]
        public int From_minute { get; set; }

        [Required]
        public int To_hour { get; set; }
        [Required]
        public int To_minute { get; set; }

        [Required]
        public DayOfWeek Day { get; set; }

        public string UnavailabilityReason { get; set; }
    }
}
