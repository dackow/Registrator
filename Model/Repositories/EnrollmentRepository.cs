using Model.Abstract;
using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class EnrollmentRepository : IEnrollment
    {
        private RegistrationsContext ctx;

        public EnrollmentRepository(RegistrationsContext context)
        {
            ctx = context;
        }

        public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return ctx.Enrollments.ToList();
        }

        public IEnumerable<Enrollment> GetEnrollmentsForDate(DateTime date)
        {
            return ctx.Enrollments.Where(x => x.Date_from.Value.Year == date.Year && x.Date_from.Value.Month == date.Month && x.Date_from.Value.Day == date.Day).ToList();
        }

        public IEnumerable<Enrollment> GetEnrollmentsForDoctor(Doctor doctor, DateTime date)
        {
            return ctx.Enrollments.Where(x => x.Doctor == doctor)
                                   .Where(x => x.Date_from.Value.Year == date.Year && x.Date_from.Value.Month == date.Month && x.Date_from.Value.Day == date.Day).ToList();            
        }

        public bool AddEnrollment(Enrollment enrollment)
        {
            ctx.Entry(enrollment).State = System.Data.Entity.EntityState.Added;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public bool DeleteEnrollment(Enrollment enrollment)
        {
            ctx.Entry(enrollment).State = System.Data.Entity.EntityState.Deleted;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public bool UpdateEnrollment(Enrollment enrollment)
        {
            ctx.Entry(enrollment).State = System.Data.Entity.EntityState.Modified;
            int i = ctx.SaveChanges();
            return i > 0;
        }
    }
}
