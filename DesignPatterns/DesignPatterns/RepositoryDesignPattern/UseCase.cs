using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.RepositoryDesignPattern
{
	public class UseCase
	{
		public void CreateOrder(IOrderRepository orderRepository, Order order)
		{
			orderRepository.Add(order);
		}
	}
}
