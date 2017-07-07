using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Moq;
using System.Data.Entity;
using Model.Initializer;
using Model;
using Model.Repositories;
using System.Windows.Forms;


namespace UnitTest
{
    [TestClass]
    public class PatientsRepositoryTest : Test
    {
        private static PatientsRepository repo;

        public PatientsRepositoryTest()
        {
            repo = new PatientsRepository(ctx);
        }

        [ClassInitialize]
        public static void Arrange(TestContext tc)
        {
            CleanUp();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            List<Patient> patients = repo.FindByNames("Józef", "Testowy");
            foreach (Patient patient in patients)
            {
                repo.Remove(patient);
            }
        }

        [TestMethod]
        public void PatientsRepositoryTest_Add_Test()
        {
            Patient patient = new Patient() { FirstName = "Józef", LastName = "Testowy", Email = "jozef.testowy@o2.pl", Address1_Street = "Baranowa 6/3", Address1_City = "34-113 Sanok", Address2_City = "Warszawa", Address2_Street = "Wiejska 3", DOB = new DateTime(2010, 1, 12), Note = "Sentator" };
            bool added = repo.Add(patient);
            Assert.IsTrue(added);
        }

        [TestMethod]
        public void PatientsRepositoryTest_FindAll_Test()
        {
            List<Patient> all = repo.FindAll().ToList();
            Assert.AreEqual(1, all.Count());
        }

        [TestMethod]
        public void PatientsRepositoryTest_FindByNames_Test()
        {
            List<Patient> all = repo.FindByNames("Józef", "Testowy");
            Assert.AreEqual(1, all.Count());
            Assert.AreEqual("Józef", all[0].FirstName);
            Assert.AreEqual("Testowy", all[0].LastName);
        }    

        [TestMethod]
        public void PatientsRepositoryTest_Update_Test()
        {
            List<Patient> patients = repo.FindByNames("Józef", "Testowy");
            Assert.AreEqual(patients.Count, 1);
            Patient patient = patients[0];
            patient.Email = "jozef.burbon@o2.pl";
            bool updated = repo.Update(patient);
            Assert.IsTrue(updated);
            patients = repo.FindByNames("Józef", "Testowy");
            Assert.AreEqual(patients.Count, 1);
            Assert.AreEqual(patients[0].Email, "jozef.burbon@o2.pl");
        }

        [TestMethod]
        public void PatientsRepositoryTest_Remove_Test()
        {
            List<Patient> patients = repo.FindByNames("Józef", "Testowy");
            Assert.AreEqual(patients.Count, 1);
            Patient patient = patients[0];
            bool removed = repo.Remove(patient);
            Assert.IsTrue(removed);
            patients = repo.FindByNames("Józef", "Testowy");
            Assert.AreEqual(patients.Count, 0);
        }

    }
}
