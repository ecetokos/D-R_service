using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAPI.Models
{
	public class Ürün_Diğer
	{
		public int Id { get; set; }
		public byte[] Photo { get; set; }
		public double Point { get; set; }
		public string Name { get; set; }
		public string P_Type { get; set; }
		public string Brand { get; set; }
		public int Discount { get; set; }
		public double Price { get; set; }
	}
}
