using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JWTAPI.Data;
using JWTAPI.Services;

namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerController : ControllerBase
    {
        private readonly IService _categoryService;
        private DataContext _context;
        public UrunlerController(DataContext context,IService categoryService)
        {
            _context = context;
            _categoryService = categoryService;
        }
        [HttpGet("kitaplar")]
        public async Task<ActionResult> GetUrunler_kitap()
        {
            var values = await _categoryService.ListAsync4();
            return Ok(values);
        }
        [HttpGet("digerleri")]
        public async Task<ActionResult> GetUrunler_diger()
        {
            var valuess = await _categoryService.ListAsync5();
            return Ok(valuess);
        }
    }
}