using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class PatientsRepository : AbstractPersonRepository<Patient>
    {
        public PatientsRepository(RegistrationsContext context) : base(context)
        {
        }
    }
}
