using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {

  
    static void Main(string[] args)
        {

            var account = new BankAccount(1000);
            account.Add(10);
            Console.WriteLine("Balanta este " + account.Balance);


            CreditFactory obj = new ConcreteCredit();

            Console.WriteLine("Ce tip de credit vrei ? ");
            string type = Console.ReadLine();
            Icredit instance = obj.GetCreditType(type);
            Console.WriteLine(instance.getcharges());
            Console.ReadLine();



            CardFactory factory = null;
            Console.Write("Enter the card type you would like to visit: ");
            string a = Console.ReadLine();

            switch (a.ToLower())
            {
                case "moneyback":
                    factory = new MoneyBackFactory(50000, 0);
                    break;
                case "business":
                    factory = new BusinessCardFactory(100000, 500);
                    break;
                case "premium":
                    factory = new PremiumCardFactory(500000, 1000);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();
        }


    }
    
}
