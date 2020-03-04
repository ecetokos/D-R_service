using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace JWTAPI.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}
		public DbSet<Kategori> Kategoriler { get; set; }
		public DbSet<Kitap_Kategori> Kitaplar { get; set; }
		public DbSet<Ürün_Kitap> Ürün_Kitaplar { get; set; }
		public DbSet<Ürün_Diğer> Ürün_Diğerleri { get; set; }
		public DbSet<Sepet> Sepettekiler { get; set; }
	}
}
