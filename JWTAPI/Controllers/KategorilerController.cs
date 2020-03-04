using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWTAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorilerController : ControllerBase
    {
        private DataContext _context;
        public KategorilerController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetCategories()
        {
            var values = await _context.Kategoriler.ToListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCategory(int id)
        {
            var value = await _context.Kategoriler.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }
        [HttpGet("kitap")]
        public async Task<ActionResult> GetSubCategory()
        {
            var subcategory = await _context.Kitaplar.ToListAsync();
            return Ok(subcategory);
        }
    }
}