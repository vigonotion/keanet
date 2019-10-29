using Microsoft.VisualStudio.TestTools.UnitTesting;
using keanet;
using System;
using System.Collections.Generic;
using System.Text;

namespace keanet.Tests
{

    [TestClass()]
    public class PurchaseTests
    {
        [TestInitialize]
        public void Testinit()
        {
            Purchase.sPurchase.Reset(new Models.CartModel());
        }

        [TestMethod()]
        public void SetInternetConnectionTrueTest()
        {
            Assert.AreEqual(Purchase.sPurchase.SetInternetConnection(true),200);
        }

        [TestMethod()]
        public void SetInternetConnectionFalseTest()
        {
            Assert.AreEqual(Purchase.sPurchase.SetInternetConnection(false),0);
        }

        [TestMethod()]
        [ExpectedException(typeof(PhoneNotFoundException))]
        public void AddPhoneNonExistingIdTest()
        {
            Purchase.sPurchase.AddPhone("xphone");
        }

        [TestMethod()]
        public void AddPhoneTest()
        {
            Purchase.sPurchase.AddPhone("moto");
            Assert.AreEqual(Purchase.sPurchase.Cart.Services[0].ID, "moto");
        }

        [TestMethod()]
        public void RemovePhoneTest()
        {
            Purchase.sPurchase.AddPhone("moto");
            Purchase.sPurchase.AddPhone("iphone");
            Purchase.sPurchase.AddPhone("samsung");

            Purchase.sPurchase.RemovePhone("iphone");

            Assert.AreEqual(Purchase.sPurchase.Cart.Services.Count, 2);
            Assert.AreEqual(Purchase.sPurchase.Cart.Services[0].ID, "moto");
            Assert.AreEqual(Purchase.sPurchase.Cart.Services[1].ID, "samsung");
        
        }

        [TestMethod()]
        [ExpectedException(typeof(PhoneNotInCartException))]
        public void RemovePhoneNotInCartIdTest()
        {
            Purchase.sPurchase.RemovePhone("xphone");
        }
    }
}