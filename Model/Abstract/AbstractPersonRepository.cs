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
            Predicate<T> p1 = x => !string.IsNullOrEmpty(lastName) ? x.LastName == lastName : false;
            Predicate<T> p2 = x => !string.IsNullOrEmpty(firstName) ? x.FirstName == firstName : true;
            Predicate<T> p3 = x => !string.IsNullOrEmpty(middleName) ? x.MiddleName == middleName : true;

            return ctx.Set<T>().AsEnumerable().ToList().FindAll(Helpers.Helpers.And(p1 + p2 + p3));
        }
    }
}
