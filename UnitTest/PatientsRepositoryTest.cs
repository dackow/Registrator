using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Moq;
using System.Data.Entity;
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
            
            //arrange
            var doctors = new Mock<DbSet<Doctor>>();
            var patients = new Mock<DbSet<Patient>>();
            //patients.Setup(x => x.ToList()).Returns(() => { return patients.Object.ToList(); });

            Mock<RegistrationsContext> ctx = new Mock<RegistrationsContext>();
            ctx.Setup(m => m.Doctors).Returns(doctors.Object);
            ctx.Setup(m => m.Patients).Returns(patients.Object);
            //ctx.Setup(m => m.Patients.ToList()).Returns(patients.Object.ToList());

            repo = new PatientsRepository(ctx.Object);

//            List<Patient> all = repo.GetAllPatients().ToList();;
            //Assert.AreEqual(3, all.Count());
        }
    }
}
