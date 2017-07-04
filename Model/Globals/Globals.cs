using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Globals
{
    public enum DoctorType
    {
        [Display(Name = "Internista")]
        Internist,
        [Display(Name = "Dentysta")]
        Dentist,
        [Display(Name = "Pediatra")]
        Pediatrician,
        [Display(Name = "Anestezjolog")]
        Anesthesiologist,
        [Display(Name = "Geriatra")]
        Geriatrician,
        [Display(Name = "Laryngolog")]
        Laryngologist,
        [Display(Name = "Pielęgniarka")]
        Nurse,
        [Display(Name = "Neurolog")]
        Neurologist,
        [Display(Name="Ginekolog")]
        Obstetrician,
        [Display(Name = "Okulista")]
        Oculist,
        [Display(Name = "Ortopeda")]
        Orthopaedist,
        [Display(Name = "Psychiatra")]
        Psychiatrist,
        [Display(Name = "Chirurg")]
        Surgeon
    }

    public enum Sex
    { 
        [Display(Name="Mężczyzna")]
        Man,
        [Display(Name="Kobieta")]
        Woman,
        [Display(Name = "Nieznany")]
        Unknown
    }
}
