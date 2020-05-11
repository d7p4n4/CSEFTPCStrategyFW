using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEFTPCStrategyFW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                BankAccount bankAccount = new BankAccount()
                {
                    BillingDetailId = 1
                };
                CreditCard creditCard = new CreditCard()
                {
                    BillingDetailId = 2,
                    CardType = 1
                };

                context.BillingDetails.Add(bankAccount);
                context.BillingDetails.Add(creditCard);

                context.SaveChanges();
            }
        }
    }
}
