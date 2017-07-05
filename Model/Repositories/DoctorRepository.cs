using Model.Abstract;
using Model.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class DoctorRepository : AbstractPersonRepository<Doctor>
    {
        public DoctorRepository(RegistrationsContext context) : base(context)
        {
        }

        public IEnumerable<Doctor> FindAvailableAt(Globals.DoctorType type, DayOfWeek day)
        {
            return FindBy(x => { return x.Type == type && x.Workdays.Any(y => y.Day == day); });
        }

        public Doctor FindByType(Globals.DoctorType type)
        {
            return FindBy(x => { return x.Type == type; }).FirstOrDefault();
        }

        public IEnumerable<WorkDay> FindScheduleForDoctor(Doctor doctor)
        {
            return doctor.Workdays.ToList();
        }
    }
}
