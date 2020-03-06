using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JWTAPI.Data;
using Microsoft.EntityFrameworkCore;
using JWTAPI.Services;
using JWTAPI.Repositories;
using AutoMapper;
using JWTAPI.Models;
using JWTAPI.Resources;

namespace JWTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorilerController : ControllerBase
    {
        private readonly IService _categoryService;
        private readonly IMapper _mapper;
       
        public KategorilerController(IService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;        
        }
        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetCategories()
        {
            var values = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Kategori>, IEnumerable<CategoryResource>>(values);
            return resources;
        }
        /*[HttpGet("{id}")]
        public async Task<ActionResult> GetCategory(int id)
        {
            var value = await _context.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }*/
        [HttpGet("kitap")]
        public async Task<ActionResult> GetSubCategory()
        {
            var subcategory = await _categoryService.ListAsync2();
            return Ok(subcategory);
        }
        [HttpGet("kitap/edebiyat")]
        public async Task<ActionResult> GetSSubCategory()
        { 
            var ssubcategory = await _categoryService.ListAsync3();
            return Ok(ssubcategory);
        }

    }
}