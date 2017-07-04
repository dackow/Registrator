using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    interface IEnrollment
    {
        IEnumerable<Enrollment> GetAllEnrollments();

        IEnumerable<Enrollment> GetEnrollmentsForDate(DateTime date);

        IEnumerable<Enrollment> GetEnrollmentsForDoctor(Doctor doctor, DateTime date);

        bool AddEnrollment(Enrollment enrollment);

        bool DeleteEnrollment(Enrollment enrollment);

        bool UpdateEnrollment(Enrollment enrollment);
    }
}
