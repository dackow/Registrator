using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class DoctorRepository : IDoctor
    {
        private RegistrationsContext ctx;
        public DoctorRepository(RegistrationsContext context)
        {
            ctx = context;
        }
        public IEnumerable<Doctor> GetAllDoctors()
        {
            return ctx.Doctors.ToList();
        }

        public IEnumerable<Doctor> GetDoctorsAvailableAt(Globals.DoctorType type, DayOfWeek day)
        {
            return ctx.Doctors.Where(x => x.Type == type && x.Workdays.Any(y=>y.Day == day));
        }

        public Doctor GetDoctor(int id)
        {
            return ctx.Doctors.Find(id);
        }

        public Doctor GetDoctor(Globals.DoctorType type)
        {
            return ctx.Doctors.Where(x => x.Type == type).FirstOrDefault();
        }

        public Doctor GetDoctor(string lastName, string firstName = "", string middleName = "")
        {
            IQueryable<Doctor> q = ctx.Doctors;
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

        public bool UpdateDoctor(Doctor doctor)
        {
            ctx.Entry(doctor).State = System.Data.Entity.EntityState.Modified;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public bool DeleteDoctor(Doctor doctor)
        {
            ctx.Entry(doctor).State = System.Data.Entity.EntityState.Deleted;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public bool AddDoctor(Doctor doctor)
        {
            ctx.Entry(doctor).State = System.Data.Entity.EntityState.Added;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public IList<DayOfWeek> GetDoctorSchedule(Doctor doctor)
        {
            if (doctor == null) return null;
            return doctor.Workdays.Select(x => x.Day) as List<DayOfWeek>;
        }
    }
}
