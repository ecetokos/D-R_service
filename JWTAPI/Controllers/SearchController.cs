using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWTAPI.Data;
using JWTAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private DataContext _context;
        public SearchController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("{searchString}")]
        public async Task<ActionResult> GetSearch(string searchString)
        {
            var results = _context.Ürün_Kitaplar.Where(x => x.Name.Contains(searchString)|| x.Author.Contains(searchString)||x.Publisher.Contains(searchString));         
            var results2 = await results.ToListAsync();
            return Ok(results2);
        }
    }
}