using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model.Concrete;
using Model.Initializer;

namespace Model
{
    public class RegistrationsContext : DbContext
    {
        public RegistrationsContext()
            : base("RegistrationCS")
        {
            Database.SetInitializer(new RegistrationDBInitializer());
            //Database.SetInitializer<RegistrationsContext>(new DropCreateDatabaseAlways<RegistrationsContext>());
        }

        public virtual DbSet<WorkDay> WorkDays { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        
        
    }
}
