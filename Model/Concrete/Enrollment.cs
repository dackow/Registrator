using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Concrete
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public virtual Doctor Doctor { get; set; }
        [Required]
        public virtual Patient Patient { get; set; }

        [Required]
        public string Room { get; set; }

        [Required]
        public DateTime? Date_from { get; set; }
        [Required]
        public DateTime? Date_to { get; set; }

        [Required]
        public Globals.EnrollmentStatus Status { get; set; }

        public string Note { get; set; }
        
    }
}
