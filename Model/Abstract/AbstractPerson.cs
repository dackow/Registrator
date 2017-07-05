using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class AbstractPerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name="Imię:")]
        public string FirstName { get; set; }
        [Display(Name = "Drugie imię:")]
        public string MiddleName { get; set; }
        [Display(Name = "Nazwisko:")]
        public string LastName { get; set; }
        [Display(Name = "Telefon kontaktowy:")]
        [Phone]        
        public string Phone1 { get; set; }
        [Display(Name = "Telefon dodatkowy:")]
        [Phone]        
        public string Phone2 { get; set; }
        [Display(Name = "Adres e-mail:")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Ulica:")]
        public string Address1_Street { get; set; }
        [Display(Name = "Miasto:")]
        public string Address1_City { get; set; }
        [Display(Name = "Ulica:")]
        public string Address2_Street { get; set; }
        [Display(Name = "Miasto:")]
        public string Address2_City { get; set; }

        [Display(Name = "Notatka:")]
        public string Note { get; set; }

    }
}
