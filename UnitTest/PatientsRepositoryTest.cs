using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Initializer;
using Model;
using Model.Repositories;

namespace UnitTest
{
    [TestClass]
    public class PatientsRepositoryTest
    {
        private PatientsRepository repo;

        public PatientsRepositoryTest()
        {
            RegistrationDBInitializer initializer = new RegistrationDBInitializer();
            RegistrationsContext ctx = new RegistrationsContext(initializer);

            repo = new PatientsRepository(ctx);
        }

        [TestMethod]
        public void GetAllPatients_Test()
        {
            //TODO

        }
    }
}
