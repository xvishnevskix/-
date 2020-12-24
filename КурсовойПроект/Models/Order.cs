﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace КурсовойПроект.Models
{
	public class Order
	{
		public  int id { get; set; }
		public string name { get; set; }
		public string surname{ get; set; }
		public string adress { get; set; }
		public string phone { get; set; }
		public string email { get; set; }
		public string orderTime { get; set; }
		public List<OrderDetail> OrderDetails { get; set; }

	}
}
