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
    }
}