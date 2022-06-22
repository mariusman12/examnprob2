using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BusinessCardFactory:CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public BusinessCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new BusinessCard(_creditLimit, _annualCharge);
        }
    }
}