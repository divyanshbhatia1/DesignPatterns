using DesignPatterns.DesignPatterns.AdaptorDesignPattern;

namespace DesignPatterns.DesignPatterns.FactoryDesignPattern
{
	public interface IPaymentProcessorAdapterFactory
	{
		IPaymentProcessorAdapter Create(string provider);
	}

	public class PaymentProcessorAdapterFactory : IPaymentProcessorAdapterFactory
	{
		public IPaymentProcessorAdapter Create(string provider)
		{
			if (provider == "Stwipe")
			{
				return new StwipeProviderAdaptor();
			}
			else if (provider == "PaySal")
			{
				return new PaySalProviderAdapter();
			}
			else
			{
				throw new InvalidPaymentProviderException(provider);
			}
		}
	}
}
