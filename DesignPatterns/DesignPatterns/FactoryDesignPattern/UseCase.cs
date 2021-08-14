using DesignPatterns.DesignPatterns.AdaptorDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.FactoryDesignPattern
{
	public class UseCase
	{
		public void Handle(IPaymentProcessorAdapterFactory factory, string paymentProvider, string merchantId, string cardNumber, string expiration,
                        decimal amount)
		{
			IPaymentProcessorAdapter adapter = factory.Create(paymentProvider);

			adapter.ProcessPayment(merchantId, cardNumber, expiration, amount);
		}
	}
}
