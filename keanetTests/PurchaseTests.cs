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
    }
}