using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    interface IPatient
    {
        IEnumerable<Patient> GetAllPatients();

        Patient GetPatient(int id);
        Patient GetPatient(string pesel);
        Patient GetPatient(string lastName, string firstName = "", string middleName = "");

        bool UpdatePatient(Patient patient);

        bool DeletePatient(Patient patient);

        bool AddPatient(Patient patient);
    }
}
