using Model;
using Model.Concrete;
using Model.Initializer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer<RegistrationsContext>(new DropCreateDatabaseAlways<RegistrationsContext>());

            using (var db = new RegistrationsContext())
            {
                db.Database.Initialize(true);
            }
        }
    }
}
