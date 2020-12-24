using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace КурсовойПроект.Models.Interfaces
{
	interface IAllOrders
	{
		void createOrder(Order order);
	}
}
