using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    interface IDoctor
    {
        IEnumerable<Doctor> GetAllDoctors();

        IEnumerable<Doctor> GetDoctorsAvailableAt(Globals.DoctorType type, DayOfWeek day);

        Doctor GetDoctor(int id);
        Doctor GetDoctor(Globals.DoctorType type);
        Doctor GetDoctor(string lastName, string firstName = "", string middleName = "");

        bool UpdateDoctor(Doctor doctor);

        bool DeleteDoctor(Doctor doctor);

        bool AddDoctor(Doctor doctor);

        IList<DayOfWeek> GetDoctorSchedule(Doctor doctor);
    }


}
