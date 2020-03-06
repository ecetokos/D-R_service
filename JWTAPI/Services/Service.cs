using JWTAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAPI.Repositories;

namespace JWTAPI.Services
{
	public class Service : IService
	{
		private readonly IRepository _categoryRepository;
		public Service(IRepository categoryRepository)
		{
			this._categoryRepository = categoryRepository;
		}
		public async Task<IEnumerable<Kategori>> ListAsync()
		{
			return await _categoryRepository.ListAsync();
		}

		public async Task<IEnumerable<Alt_Kategori>> ListAsync2()
		{
			return await _categoryRepository.ListAsync2();
		}

		public async Task<IEnumerable<AAlt_Kategori>> ListAsync3()
		{
			return await _categoryRepository.ListAsync3();
		}

		public async Task<IEnumerable<Ürün_Kitap>> ListAsync4()
		{
			return await _categoryRepository.ListAsync4();
		}

		public async Task<IEnumerable<Ürün_Diğer>> ListAsync5()
		{
			return await _categoryRepository.ListAsync5();
		}
	}
}
