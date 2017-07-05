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

        public IEnumerable<Patient> GetAllPatients()
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

        public Patient GetPatient(string lastName, string firstName = "", string middleName = "")
        {
            IQueryable<Patient> q = ctx.Patients;
            if (!string.IsNullOrEmpty(lastName))
            {
                q = q.Where(x => x.LastName == lastName);
            }

            if (!string.IsNullOrEmpty(firstName))
            {
                q = q.Where(x => x.FirstName == firstName);
            }

            if (!string.IsNullOrEmpty(middleName))
            {
                q = q.Where(x => x.MiddleName == middleName);
            }

            return q.FirstOrDefault();
        }

        public bool UpdatePatient(Patient patient)
        {
            ctx.Entry(patient).State = System.Data.Entity.EntityState.Modified;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public bool DeletePatient(Patient patient)
        {
            ctx.Entry(patient).State = System.Data.Entity.EntityState.Deleted;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public bool AddPatient(Patient patient)
        {
            ctx.Entry(patient).State = System.Data.Entity.EntityState.Added;
            int i = ctx.SaveChanges();
            return i > 0;
        }
    }
}
