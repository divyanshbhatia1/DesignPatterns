﻿using System;
using System.Runtime.Serialization;

namespace DesignPatterns.DesignPatterns.FactoryDesignPattern
{
	[Serializable]
	internal class InvalidPaymentProviderException : Exception
	{
		public InvalidPaymentProviderException()
		{
		}

		public InvalidPaymentProviderException(string message) : base(message)
		{
		}

		public InvalidPaymentProviderException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected InvalidPaymentProviderException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}