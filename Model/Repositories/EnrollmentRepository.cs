using Model.Abstract;
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

        public IEnumerable<Concrete.Enrollment> GetAllEnrollments()
        {
            return ctx.Enrollments;
        }

        public IEnumerable<Concrete.Enrollment> GetEnrollmentsForDate(DateTime date)
        {
            DateTime? d = date.
            //var q = ctx.Enrollments.Where(x=>x.Date_from);
        }

        public IEnumerable<Concrete.Enrollment> GetEnrollmentsForDoctor(Doctor doctor, DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool AddEnrollment(Concrete.Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEnrollment(Concrete.Enrollment enrollment)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEnrollment(Concrete.Enrollment enrollment)
        {
            throw new NotImplementedException();
        }
    }
}
