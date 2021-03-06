﻿using Model.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patient : AbstractPerson
    {
        [Display(Name = "Płeć:")]
        public Sex Sex { get; set; }

        [Display(Name = "PESEL")]
        public string Pesel { get; set; }
        [Display(Name = "Data urodzenia:")]

        public DateTime? DOB { get; set; }
        [Display(Name = "Data śmierci:")]      
        public DateTime? DOD { get; set; }

    }
}
