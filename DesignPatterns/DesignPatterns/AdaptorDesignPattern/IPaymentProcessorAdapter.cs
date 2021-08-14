using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.AdaptorDesignPattern
{
	public interface IPaymentProcessorAdapter
	{
		bool ProcessPayment(string merchantId, string cardNumber, string expiration,
						decimal amount);
	}
}
