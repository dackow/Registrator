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

        private static Mock<DbSet<T>> CreateDbSetMock<T>(IEnumerable<T> elements) where T : class
        {
            var elementsAsQueryable = elements.AsQueryable();
            var dbSetMock = new Mock<DbSet<T>>();

            dbSetMock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(elementsAsQueryable.Provider);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(elementsAsQueryable.Expression);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(elementsAsQueryable.ElementType);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(elementsAsQueryable.GetEnumerator());

            return dbSetMock;
        }

        public PatientsRepositoryTest()
        {
            RegistrationDBInitializer initializer = new RegistrationDBInitializer();
            RegistrationsContext ctx = new RegistrationsContext(initializer);

            repo = new PatientsRepository(ctx);
        }

        [TestMethod]
        public void FindAll_Test()
        {
            List<Patient> all = repo.FindAll().ToList();
            Assert.AreEqual(3, all.Count());
        }

        [TestMethod]
        public void FindByNames_Test()
        {
            List<Patient> all = repo.FindByNames("dacko", string.Empty, "maciej");
            Assert.AreEqual(1, all.Count());
            Assert.AreEqual("Dacko", all[0].LastName);
        }

        
    }
}
