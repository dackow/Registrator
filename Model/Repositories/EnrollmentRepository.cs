using Model.Abstract;
using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class EnrollmentRepository : AbstractRepository<Enrollment>// IEnrollment
    {
        public EnrollmentRepository(RegistrationsContext context) : base(context){}

        public IEnumerable<Enrollment> FindForDate(DateTime date)
        {
            return FindBy(x => { return x.Date_from.Value.Year == date.Year && x.Date_from.Value.Month == date.Month && x.Date_from.Value.Day == date.Day; });
        }

        public IEnumerable<Enrollment> FindForDoctor(Doctor doctor, DateTime date)
        {
            return FindBy(x => { return  x.Doctor == doctor && x.Date_from.Value.Year == date.Year && x.Date_from.Value.Month == date.Month && x.Date_from.Value.Day == date.Day; });
        }

    }
}
