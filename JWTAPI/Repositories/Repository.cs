using JWTAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWTAPI.Data;
//using JWTAPI.Models;

namespace JWTAPI.Repositories
{
	public class Repository : BaseRepository, IRepository
	{
		public Repository(DataContext context) : base(context)
		{

		}
		public async Task<IEnumerable<Kategori>> ListAsync()
		{
			return await _context.Kategoriler.ToListAsync();
		}

		public async Task<IEnumerable<Alt_Kategori>> ListAsync2()
		{
			return await _context.Kitaplar.ToListAsync();
		}

		public async Task<IEnumerable<AAlt_Kategori>> ListAsync3()
		{
			return await _context.AAlt_Kategoriler.ToListAsync();
		}

		public async Task<IEnumerable<Ürün_Kitap>> ListAsync4()
		{
			return await _context.Ürün_Kitaplar.ToListAsync();
		}

  		public async Task<IEnumerable<Ürün_Diğer>> ListAsync5()
		{
			return await _context.Ürün_Diğerleri.ToListAsync();
		}
	}
}