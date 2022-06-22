using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ConcreteCredit:CreditFactory
    {
        public override Icredit GetCreditType(string type)
        {
           switch (type)
            {
                case "Monthly":
                    return new Monthly();
                case "Yearly":
                    return new Yearly();
                default:
                    throw new ApplicationException (string.Format("credit,'{0}' not availalbe",type));
            }

        }
    }
}
