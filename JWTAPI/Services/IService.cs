using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAPI.Models;

namespace JWTAPI.Services
{
	public interface IService
	{
		Task<IEnumerable<Kategori>> ListAsync();
		Task<IEnumerable<Alt_Kategori>> ListAsync2();
		Task<IEnumerable<AAlt_Kategori>> ListAsync3();
		Task<IEnumerable<Ürün_Kitap>> ListAsync4();
		Task<IEnumerable<Ürün_Diğer>> ListAsync5();
	}
}
