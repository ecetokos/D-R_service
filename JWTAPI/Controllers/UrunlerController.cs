using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JWTAPI.Data;

namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerController : ControllerBase
    {
        private DataContext _context;
        public UrunlerController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("kitaplar")]
        public async Task<ActionResult> GetUrunler_kitap()
        {
            var values = await _context.Ürün_Kitaplar.ToListAsync();
            return Ok(values);
        }
        [HttpGet("digerleri")]
        public async Task<ActionResult> GetUrunler_diger()
        {
            var valuess = await _context.Ürün_Diğerleri.ToListAsync();
            return Ok(valuess);
        }
    }
}