using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.AdaptorDesignPattern
{
    public class StwipeProvider
    {
        public StwipeProvider(string merchantKey)
        { }

        // returns false if payment is rejected
        public bool Pay(string cardNumber, string expiration, decimal amount)
        {
            if (amount < 1) return false;

            return true;
        }
    }

    public class PaySalProvider
    {
        // throws exception if payment is rejected
        public void ProcessPayment(string merchantId, CreditCardDetails cardInfo, decimal amount)
        { }
	}

	public class CreditCardDetails
	{
		private string cardNumber;
		private string expiration;

		public CreditCardDetails(string cardNumber, string expiration)
		{
			this.cardNumber = cardNumber;
			this.expiration = expiration;
		}
	}
}
