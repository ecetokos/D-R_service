using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWTAPI.Models;
using JWTAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SepetimController : ControllerBase
    {
        private DataContext _context;
        public SepetimController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetSepet()
        {
            var values = await _context.Sepettekiler.ToListAsync();
            return Ok(values);
        }
        [HttpPost("{id}")]
        public async Task<ActionResult> GetSepets(int id)
        {
            var value = await _context.Ürün_Kitaplar.FirstOrDefaultAsync(x => x.Id == id);
            var urun = new Sepet
            {
                Id = value.Id,
                Name = value.Name,
                Photo = value.Photo,
                Price = value.Price,
            };           
            return Ok();

        }
    }
}