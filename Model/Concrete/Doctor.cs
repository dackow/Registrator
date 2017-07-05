using Model.Concrete;
using Model.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Doctor : AbstractPerson
    {
        public DoctorType Type { get; set; } /*internist, dentist,...*/

        public virtual List<WorkDay> Workdays{ get; set; }
    }
}
