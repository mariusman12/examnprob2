using Bank;
using NUnit.Framework;


namespace BankNUnitTests
{
    public class BankNUnitTests
    {
      
    
      

        [Test]
        public void Adding_Funds_Updates_Balance()
        {
            //ARRAGE
            var account = new BankAccount(1000);

            //ACT
            account.Add(500);

            //ASSERT
            Assert.AreEqual(1500, account.Balance);
        }
        [Test]
        public void Withrawing_Funds_Updates_Balance()
        {
            //ARRAGE
            var account = new BankAccount(1000);

            //ACT
            account.Withdraw(500);

            //ASSERT
            Assert.AreEqual(500, account.Balance);

        }


        [Test]
        public void Transfering_Funds_Updates_Both_Account()
        {
            //ARRAGE
            var account = new BankAccount(1000);
            var ottherAccount = new BankAccount();

            //ACT
            account.TransferFundsTo(ottherAccount, 500);

            //ASSERT
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(500, ottherAccount.Balance);
        }
    }
}