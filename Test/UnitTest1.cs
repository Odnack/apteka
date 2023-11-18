using System;
using System.Linq;
using DataBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var password = "1234";
            var login = "1234";
            using (var db = new Apteka())
            {
                var user = db.pharmacies.FirstOrDefault(x => x.login == login && x.password == password);
                Assert.IsNotNull(user);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (var db = new Apteka())
            {
                var pharmacyId = 1;
                var medicinceId = 1;
                var quantity = 10;
                var application = new applications
                {
                    pharmacyId = pharmacyId,
                    applicationDate = DateTime.Now
                };
                var procurements = new procurements
                {
                    applications = application,
                    medicinceId = medicinceId,
                    quantity = quantity
                };
                db.applications.Add(application);
                db.procurements.Add(procurements);
                db.SaveChanges();

                var procurement = db.procurements.FirstOrDefault(x => x.applications.pharmacyId == pharmacyId && x.medicinceId == medicinceId);
                Assert.IsNotNull(procurement);
                db.applications.Remove(application);
                db.procurements.Remove(procurements);
                db.SaveChanges();
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            var medicineName = "test";
            var medicinePrice = 100.0f;
            using (var db = new Apteka())
            {
                var medicinces = new medicines()
                {
                    medicineName = medicineName,
                    medicinePrice = medicinePrice
                };
                db.medicines.Add(medicinces);
                db.SaveChanges();

                var medicince = db.medicines.FirstOrDefault(x => x.medicineName == medicineName && x.medicinePrice == medicinePrice);

                Assert.IsNotNull(medicince);
                db.medicines.Remove(medicinces);
                db.SaveChanges();
            }
        }
    }
}
