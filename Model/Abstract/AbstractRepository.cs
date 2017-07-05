using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Model.Abstract
{
    abstract public class AbstractRepository<T> where T : class
    {
        protected RegistrationsContext ctx = null;

        private AbstractRepository(){}

        public AbstractRepository(RegistrationsContext context)
        {
            ctx = context;
        }

        public IEnumerable<T> FindAll()
        {
            return ctx.Set<T>();
        }

        protected IEnumerable<T> FindBy(Predicate<T> predicate)
        {
            return ctx.Set<T>().AsEnumerable().ToList().FindAll(predicate).ToList();
        }

        public T FindById(int d)
        {
            return ctx.Set<T>().Find(d);
        }

        public bool Add(T newEntity)
        {            
            ctx.Entry(newEntity).State = System.Data.Entity.EntityState.Added;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public bool Update(T entity)
        {
            ctx.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            int i = ctx.SaveChanges();
            return i > 0;
        }

        public bool Remove(T entity)
        {
            ctx.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            int i = ctx.SaveChanges();
            return i > 0;
        }
    }
}
