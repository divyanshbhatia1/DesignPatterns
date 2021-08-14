using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.RepositoryDesignPattern
{
    public interface IOrderRepository
    {
        Order GetById(int id);
        List<Order> List();
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
