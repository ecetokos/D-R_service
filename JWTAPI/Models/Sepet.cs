using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAPI.Core.Models;

namespace JWTAPI.Models
{
	public class Sepet
	{
		//public User User { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public byte[] Photo { get; set; }
		public int Id { get; set; }
	}
}
