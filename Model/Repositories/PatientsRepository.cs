using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class PatientsRepository : IPatient
    {
        private RegistrationsContext ctx;
        public PatientsRepository(RegistrationsContext context)
        {
            ctx = context;
        }

        public IEnumerable<Person> GetAllPatients()
        {
            return ctx.Patients.ToList();
        }

        public Patient GetPatient(int id)
        {
            return ctx.Patients.Find(id);
        }

        public Patient GetPatient(string pesel)
        {
            return ctx.Patients.Where(x => x.Pesel == pesel).FirstOrDefault();
        }

        public Patient GetPatient(string firstName, string lastName, string middleName = "")
        {
             throw new NotImplementedException();
            //var q = ctx.Patients;
            //if (!string.IsNullOrEmpty(firstName))
            //{ 
            //    q = q.Where(x=>)
            //}
        }

        public bool UpdatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool DeletePatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
