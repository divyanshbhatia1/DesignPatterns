using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.AdaptorDesignPattern
{

	public class StwipeProviderAdaptor : IPaymentProcessorAdapter
	{
		public bool ProcessPayment(string merchantId, string cardNumber, string expiration,
							decimal amount)
		{
			var provider = new StwipeProvider(merchantId);
			return provider.Pay(cardNumber, expiration, amount);
		}
	}

    public class PaySalProviderAdapter : IPaymentProcessorAdapter
{
    public bool ProcessPayment(string merchantId,
        string cardNumber, string expiration,
        decimal amount)
    {
        var provider = new PaySalProvider();
        try
        {
            var cardInfo = new CreditCardDetails(cardNumber, expiration);
            provider.ProcessPayment(merchantId, cardInfo, amount);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
}
