using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using System;

namespace BankUnitTest
{
    [TestClass]
    public class BankUbitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var account = new BankAccount(100);
        }
    }
}
