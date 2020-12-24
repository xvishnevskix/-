using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using КурсовойПроект.Areas.Admin.Controllers;
using КурсовойПроект.Domain.Entities;

namespace КурсовойПроект.Models
{
	public class OrderDetail
	{
		public int id { get; set; }
		public int orderID { get; set; }
		public int itemID { get; set; }
		public ushort price { get; set; }

		public virtual ServiceItem serviceitem { get; set; }
		public virtual Order order { get; set; }
		
	}
}
