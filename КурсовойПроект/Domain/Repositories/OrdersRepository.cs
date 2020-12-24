using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using КурсовойПроект.Models;
using КурсовойПроект.Models.Interfaces;

namespace КурсовойПроект.Domain.Repositories
{
	public class OrdersRepository : IAllOrders
	{
		private readonly AppDbContext appDbContext;


		public void createOrder(Order order)
		{
			
			appDbContext.Order.Add(order);

			
		}
	}
}
