using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Initializer
{
    public class RegistrationDBInitializer : DropCreateDatabaseAlways<RegistrationsContext>
    {
        public void AutoInitialize(RegistrationsContext context)
        {
            Seed(context);
        }

        protected override void Seed(RegistrationsContext context)
        {

            /****************** doctors ******************/
            Doctor doctor1 = new Doctor { FirstName = "Matt", 
                                            LastName = "Scorpion", 
                                            MiddleName = "Lukas", 
                                            Email = "matt.scorpion@example.com", 
                                            Phone1 = "509808144", 
                                            Address1_Street = "Malczewskiego 7/32", 
                                            Address1_City = "35-114 Rzeszów" };


            List<WorkDay> workDays1 = new List<WorkDay> { new WorkDay { Day = DayOfWeek.Monday, From_hour = 8, From_minute = 0, To_hour = 16, To_minute = 0, UnavailabilityReason = string.Empty } ,
                                                             new WorkDay { Day = DayOfWeek.Tuesday, From_hour = 8, From_minute = 0, To_hour = 16, To_minute = 0, UnavailabilityReason = string.Empty },
                                                             new WorkDay { Day = DayOfWeek.Wednesday, From_hour = 13, From_minute = 0, To_hour = 17, To_minute = 30, UnavailabilityReason = string.Empty },
                                                             new WorkDay { Day = DayOfWeek.Thursday, From_hour = 8, From_minute = 0, To_hour = 16, To_minute = 0, UnavailabilityReason = "Szkolenie" },
                                                             new WorkDay { Day = DayOfWeek.Friday, From_hour = 15, From_minute = 0, To_hour = 18, To_minute = 30}};

            doctor1.Workdays = workDays1;
            context.Doctors.Add(doctor1);

            Doctor doctor2 = new Doctor { FirstName = "Simon", 
                                            LastName = "Beckett", 
                                            Email = "simon.beckett@gmail.com", 
                                            Phone1 = "502304426", 
                                            Address1_Street = "Jana III Sobieskiego 7/32", 
                                            Address1_City = "38-700 Ustrzyki Dolne" };


            List<WorkDay> workDays2 = new List<WorkDay> { new WorkDay { Day = DayOfWeek.Monday, From_hour = 8, From_minute = 0, To_hour = 16, To_minute = 0, UnavailabilityReason = string.Empty } ,
                                                             new WorkDay { Day = DayOfWeek.Tuesday, From_hour = 8, From_minute = 0, To_hour = 16, To_minute = 0, UnavailabilityReason = string.Empty },
                                                             new WorkDay { Day = DayOfWeek.Wednesday, From_hour = 13, From_minute = 0, To_hour = 17, To_minute = 30, UnavailabilityReason = string.Empty },
                                                             new WorkDay { Day = DayOfWeek.Thursday, From_hour = 8, From_minute = 0, To_hour = 16, To_minute = 0, UnavailabilityReason = "Szkolenie" },
                                                             new WorkDay { Day = DayOfWeek.Friday, From_hour = 15, From_minute = 0, To_hour = 18, To_minute = 30}};

            doctor2.Workdays = workDays2;
            context.Doctors.Add(doctor2);

            /****************** patients ******************/
            Patient patient1 = new Patient { FirstName = "Waldemar", 
                                             MiddleName = "Maciej", 
                                             LastName = "Dacko", 
                                             Address1_Street = "Jagiellońska 48/35", 
                                             Address1_City = "38-700 Ustrzyki Dolne", 
                                             DOB = new DateTime(1982,10,10,8,0,0), 
                                             Email = "waldemar.dacko@gmail.com", 
                                             Pesel = "82101013172", 
                                             Sex = Globals.Sex.Man,  
                                             Note = "Donieść skierowanie do okulisty"};
            context.Patients.Add(patient1);

            Patient patient2 = new Patient { FirstName = "Sylwester",
                                             LastName = "Kosowski",
                                             Address1_Street = "Jagiellońska 44/15",
                                             Address1_City = "38-700 Ustrzyki Dolne",
                                             DOB = new DateTime(1982, 12, 1, 15, 35, 0),
                                             Email = "kosa@gmail.com",
                                             Pesel = "82120123433",
                                             Sex = Globals.Sex.Man};
            context.Patients.Add(patient2);

            Patient patient3 = new Patient
            {
                FirstName = "Natalia",
                LastName = "Kowalska",
                Address1_Street = "Króla Augusta 1/34",
                Address1_City = "35-111 Rzeszów",
                DOB = new DateTime(1978, 1, 12, 12, 15, 0),
                Email = "natpotocka@gmail.com",
                Pesel = "78011233234",
                Sex = Globals.Sex.Woman
            };

            List<Patient> patients = new List<Patient>{ patient1, patient2, patient3};
            context.Patients.AddRange(patients);


            base.Seed(context);


        }
    }
}
