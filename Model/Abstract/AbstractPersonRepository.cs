using Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public class AbstractPersonRepository<T> : AbstractRepository<T> where T : AbstractPerson
    {
        public AbstractPersonRepository(RegistrationsContext context) : base(context) {}

        public List<T> FindByNames(string lastName, string firstName = "", string middleName = "")
        {
            Predicate<T> p1 = x => Helpers.Helpers.CompareStrings(lastName, x.LastName, false);
            Predicate<T> p2 = x => Helpers.Helpers.CompareStrings(firstName, x.FirstName, true);
            Predicate<T> p3 = x => Helpers.Helpers.CompareStrings(middleName, x.MiddleName, true);

            return ctx.Set<T>().AsEnumerable().ToList().FindAll(Helpers.Helpers.And(p1 + p2 + p3));
        }

        
    }
}
