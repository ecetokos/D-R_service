using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAPI.Models
{
	public class Ürün_Kitap
	{
		public int SubC_Id { get; set; } 
		public int Id { get; set; }
		public byte[] Photo { get; set; }
		public double Point { get; set; }	
		public string Name { get; set; }
		public string Author { get; set; }	
		public string CoverType { get; set; }
		public string Publisher { get; set; }	
		public int Discount { get; set; }
		public double Price { get; set; }		
	}
}
