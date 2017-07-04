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
        public IEnumerable<Doctor> GetAllDoctors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetDoctorsAvailableAt(Globals.DoctorType type, IList<DayOfWeek> days)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(Globals.DoctorType type)
        {
            throw new NotImplementedException();
        }

        public Doctor GetDoctor(string lastName, string firstName = "", string middleName = "")
        {
            throw new NotImplementedException();
        }

        public bool UpdateDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public bool AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public IList<DayOfWeek> GetDoctorSchedule(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
