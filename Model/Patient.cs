using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patient : Person
    {
        [Display(Name = "Płeć:")]
        public string Sex { get; set; }

        [Display(Name = "PESEL")]
        public string Pesel { get; set; }
        [Display(Name = "Data urodzenia:")]
        public DateTime DOB { get; set; }
        [Display(Name = "Data śmierci:")]
        public DateTime DOD { get; set; }

    }
}
